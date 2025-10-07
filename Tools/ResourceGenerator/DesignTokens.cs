// COPYRIGHT © 2025 Esri
// All rights reserved under the copyright laws of the United States and applicable international laws, treaties, and conventions.
// This material is licensed for use under the Esri Master License Agreement (MLA), and is bound by the terms of that agreement.
// You may redistribute and use this code without modification, provided you adhere to the terms of the MLA and include this copyright notice.
//
// See use restrictions at http://www.esri.com/legal/pdfs/mla_e204_e300/english
//
// For additional information, contact: Environmental Systems Research Institute, Inc.
// Attn: Contracts and Legal Services Department 380 New York Street Redlands, California, USA 92373 USA. email: contracts@esri.com

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ResourceGenerator
{
    internal static class DesignTokens
    {
        public enum ColorType
        {
            Core,
            SemanticDark,
            SemanticLight,
        }
        public class ColorEntry
        {
            public string DesignTokenId { get; set; }
            public string ResourceId => ColorTokenToString(DesignTokenId);
            public string? Value => Json["value"] is not JObject ? Json["value"].ToString() : null;
            public string? System => Json["attributes"] is JObject ? ((JObject)((JObject)Json["attributes"])["calcite-schema"])["system"].ToString() : null;
            public string? Group => Json["attributes"] is JObject ? ((JObject)((JObject)Json["attributes"])["calcite-schema"])["group"].ToString() : null;
            public JObject Json { get; set; }
            public ColorType Type { get; set; }
            public override string ToString() => $"{ResourceId} = {Value}";

            public void UpdateReferenceColors(Dictionary<string, ColorEntry> entries, Dictionary<string, ColorEntry> coreEntries)
            {
                if (Value is not null) Json["value"] = GetColor(Value, entries, coreEntries);
            }
            private string GetColor(string value, Dictionary<string,ColorEntry> entries, Dictionary<string, ColorEntry> coreEntries)
            {
                if (value is not null && value.StartsWith('{') && value.EndsWith('}'))
                {
                    var key = value.Substring(1, value.Length - 2);
                    if (entries.ContainsKey(key))
                        return entries[key].Value;
                    if (coreEntries.ContainsKey(key))
                        return coreEntries[key].Value;
                }
                if (value.StartsWith("rgba(") && value.EndsWith(')'))
                {
                    value = value.Substring(5, value.Length - 6);
                    var parts = value.Split(",");
                    var color = GetColor(parts[0].Trim(), entries, coreEntries);
                    var opacity = double.Parse(parts[1].Trim().TrimEnd('}').Split('.').Last());
                    color = $"#{((int)Math.Round(opacity / 100 * 255)).ToString("x2")}{color.Substring(1)}";
                    return color; //TODO: Opacity
                }
                if(value.StartsWith('{') && value.EndsWith('}'))
                {
                    
                }
                return value;
            }

        }

        public static IEnumerable<ColorEntry> GenerateDesignTokens(string designTokensFolder)
        {
            var coreColorsFile = Path.Combine(designTokensFolder, "src\\tokens\\core\\color.json");
            string semanticColorsLightFile = Path.Combine(designTokensFolder, @"src\tokens\semantic\color\light.json");
            string semanticColorsDarkFile = Path.Combine(designTokensFolder, @"src\tokens\semantic\color\dark.json");

            // Load all tokens for later lookup
            JObject coretokens = new JObject();
            foreach (var file in Directory.GetFiles(Path.Combine(designTokensFolder, "src\\tokens\\core"), "*.json"))
            {
                var json = (JObject)JsonConvert.DeserializeObject(File.ReadAllText(file))!;
                coretokens.Merge(json);
            }
            var coreColors = (JObject)JsonConvert.DeserializeObject(File.ReadAllText(coreColorsFile))!;

            // Generate core colors
            var core = (JObject)((JObject)coretokens["core"]!)["color"]!;
            var colors = new Dictionary<string, ColorEntry>();
            
            foreach (var item in core)
            {
                string group = item.Key;
                foreach (var member in (JObject)item.Value!)
                {
                    string name = member.Key;
                    if (GetColor((JObject)member.Value, out string color))
                    {
                        colors.Add($"core.color.{group}.{name}", new ColorEntry { DesignTokenId = $"{group}.{name}", Json = (JObject)member.Value });
                    }
                    else
                        foreach (var entry in (JObject)member.Value)
                        {
                            if (GetColor((JObject)entry.Value, out color))
                                colors.Add($"core.color.{group}.{name}.{entry.Key}", new ColorEntry { DesignTokenId = $"{group}.{name}.{entry.Key}", Json = (JObject)entry.Value });
                        }
                }
            }

            // Parse semantic colors
            var semanticColorsLightJson = (JObject)JsonConvert.DeserializeObject(File.ReadAllText(semanticColorsLightFile))!;
            var semanticColorsDarkJson = (JObject)JsonConvert.DeserializeObject(File.ReadAllText(semanticColorsDarkFile))!;
            var semanticLight = (JObject)((JObject)semanticColorsLightJson["semantic"]!)["color"]!;
            var semanticDark = (JObject)((JObject)semanticColorsDarkJson["semantic"]!)["color"]!;
            var semanticColorsLight = new Dictionary<string, ColorEntry>();
            var semanticColorsDark = new Dictionary<string, ColorEntry>();
            foreach (var item in semanticLight)
            {
                string group = item.Key;
                foreach (var member in (JObject)item.Value!)
                {
                    string name = member.Key;
                    if (member.Value is JObject)
                    {
                        if (GetColor((JObject)member.Value, out string color))
                        {
                            semanticColorsLight.Add($"semantic.color.{group}.{name}", new ColorEntry { DesignTokenId = $"{group}.{name}", Json = (JObject)member.Value, Type = ColorType.SemanticLight });
                        }
                        else
                            foreach (var entry in (JObject)member.Value)
                            {
                                if (GetColor((JObject)entry.Value, out color))
                                    semanticColorsLight.Add($"semantic.color.{group}.{name}.{entry.Key}", new ColorEntry { DesignTokenId = $"{group}.{name}.{entry.Key}", Json = (JObject)entry.Value, Type = ColorType.SemanticLight });
                            }
                    }
                }
            }
            foreach (var item in semanticDark)
            {
                string group = item.Key;
                foreach (var member in (JObject)item.Value!)
                {
                    string name = member.Key;
                    if (member.Value is JObject)
                    {
                        if (GetColor((JObject)member.Value, out string color))
                        {
                            semanticColorsDark.Add($"semantic.color.{group}.{name}", new ColorEntry { DesignTokenId = $"{group}.{name}", Json = (JObject)member.Value, Type = ColorType.SemanticDark });
                        }
                        else
                            foreach (var entry in (JObject)member.Value)
                            {
                                if (GetColor((JObject)entry.Value, out color))
                                    semanticColorsDark.Add($"semantic.color.{group}.{name}.{entry.Key}", new ColorEntry { DesignTokenId = $"{group}.{name}.{entry.Key}", Json = (JObject)entry.Value, Type = ColorType.SemanticDark });
                            }
                    }
                }
            }
            foreach (var item in semanticColorsLight)
            {
                item.Value.UpdateReferenceColors(semanticColorsLight, colors);
            }
            foreach (var item in semanticColorsDark)
            {
                item.Value.UpdateReferenceColors(semanticColorsDark, colors);
            }

            return colors.Values.Concat(semanticColorsLight.Values).Concat(semanticColorsDark.Values);
        }

        private static string ColorTokenToString(string color)
        {
            var parts = color.Split(new char[] { '.', '-' });
            return string.Join("", parts.Select(p =>
             p switch
             {
                 "default" => "",
                 "h" => "",
                 "d" => "",
                 "v" => "",
                 "blk" => "Gray",
                 "bb" => "",
                 "br" => "",
                 "gb" => "",
                 "gg" => "",
                 "yg" => "",
                 "yy" => "",
                 "oy" => "",
                 "oo" => "",
                 "ro" => "",
                 "rr" => "",
                 "pk" => "",
                 "vr" => "",
                 "vv" => "",
                 _ => p.Substring(0, 1).ToUpper() + p.Substring(1)
             }));
        }

        static JToken? GetToken(JObject graph, string token)
        {
            var tokens = token.Split('.');
            foreach (var item in tokens)
            {
                if (!graph.ContainsKey(item))
                    return null;
                graph = (JObject)graph[item];
            }
            return graph;
        }
        static bool GetColor(JObject? colorEntry, out string color)
        {
            color = "";
            if(colorEntry is null)
                return false;
            if (colorEntry.ContainsKey("value") && colorEntry.ContainsKey("type") && colorEntry["type"].ToString() == "color")
            {
                color = colorEntry["value"].ToString();
                return true;
            }
            return false;
        }
    }
}
