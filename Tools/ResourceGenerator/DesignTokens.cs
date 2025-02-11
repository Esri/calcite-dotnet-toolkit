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
        public class ColorEntry
        {
            public string DesignTokenId { get; set; }
            public string ResourceId => ColorTokenToString(DesignTokenId);
            public string? Value => Json["value"] is not JObject ? Json["value"].ToString() : null;
            public string? DarkValue => Json["value"] is JObject ? ((JObject)Json["value"])["dark"].ToString() : null;
            public string? LightValue => Json["value"] is JObject ? ((JObject)Json["value"])["light"].ToString() : null;
            public string? Tier => Json["attributes"] is JObject ? ((JObject)((JObject)Json["attributes"])["calcite-schema"])["tier"].ToString() : null;
            public string? System => Json["attributes"] is JObject ? ((JObject)((JObject)Json["attributes"])["calcite-schema"])["system"].ToString() : null;
            public string? Group => Json["attributes"] is JObject ? ((JObject)((JObject)Json["attributes"])["calcite-schema"])["group"].ToString() : null;
            public JObject Json { get; set; }
            public override string ToString() => $"{ResourceId} = {Value ?? $"{LightValue}/{DarkValue}" }";

            public void UpdateReferenceColors(Dictionary<string, ColorEntry> entries)
            {
                if(Value is not null) Json["value"] = GetColor(Value, entries);
                if (DarkValue is not null) ((JObject)Json["value"])["dark"] = GetColor(DarkValue, entries);
                if (LightValue is not null) ((JObject)Json["value"])["light"] = GetColor(LightValue, entries);
            }
            private string GetColor(string value, Dictionary<string,ColorEntry> entries)
            {
                if (value is not null && value.StartsWith('{') && value.EndsWith('}'))
                {
                    var key = value.Substring(1, value.Length - 2);
                    if (entries.ContainsKey(key))
                        return entries[key].Value;
                }
                if (value.StartsWith("rgba(") && value.EndsWith(')'))
                {
                    value = value.Substring(5, value.Length - 6);
                    var parts = value.Split(",");
                    var color = GetColor(parts[0].Trim(), entries);
                    var opacity = double.Parse(parts[1].Trim().TrimEnd('}').Split('.').Last());
                    color = $"#{((int)Math.Round(opacity / 100 * 255)).ToString("x2")}{color.Substring(1)}";
                    return color; //TODO: Opacity
                }
                return value;
            }

        }

        public static IEnumerable<ColorEntry> GenerateDesignTokens(string designTokensFolder)
        {
            var coreColorsFile = Path.Combine(designTokensFolder, "src\\core\\color.json");
            string semanticColorsFile = Path.Combine(designTokensFolder, @"src\semantic\color.json");

            // Load all tokens for later lookup
            JObject coretokens = new JObject();
            foreach (var file in Directory.GetFiles(Path.Combine(designTokensFolder, "src\\core"), "*.json"))
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
            var semanticColorsJson = (JObject)JsonConvert.DeserializeObject(File.ReadAllText(semanticColorsFile))!; 
            var semantic = (JObject)((JObject)semanticColorsJson["semantic"]!)["color"]!;
            var semanticColors = new Dictionary<string, ColorEntry>();
            foreach (var item in semantic)
            {
                string group = item.Key;
                foreach (var member in (JObject)item.Value!)
                {
                    string name = member.Key;
                    if (member.Value is JObject)
                    {
                        if (GetColor((JObject)member.Value, out string color))
                        {
                            semanticColors.Add($"semantic.color.{group}.{name}", new ColorEntry { DesignTokenId = $"{group}.{name}", Json = (JObject)member.Value });
                        }
                        else
                            foreach (var entry in (JObject)member.Value)
                            {
                                if (GetColor((JObject)entry.Value, out color))
                                    semanticColors.Add($"semantic.color.{group}.{name}.{entry.Key}", new ColorEntry { DesignTokenId = $"{group}.{name}.{entry.Key}", Json = (JObject)entry.Value });
                            }
                    }
                }
            }
            foreach(var item in semanticColors)
            {
                item.Value.UpdateReferenceColors(colors);
            }

            return colors.Values.Concat(semanticColors.Values);
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
