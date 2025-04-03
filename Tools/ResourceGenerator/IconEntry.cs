// COPYRIGHT © 2025 Esri
// All rights reserved under the copyright laws of the United States and applicable international laws, treaties, and conventions.
// This material is licensed for use under the Esri Master License Agreement (MLA), and is bound by the terms of that agreement.
// You may redistribute and use this code without modification, provided you adhere to the terms of the MLA and include this copyright notice.
//
// See use restrictions at http://www.esri.com/legal/pdfs/mla_e204_e300/english
//
// For additional information, contact: Environmental Systems Research Institute, Inc.
// Attn: Contracts and Legal Services Department 380 New York Street Redlands, California, USA 92373 USA. email: contracts@esri.com

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IconXamlGenerator
{
    internal class IconEntry
    {
        public static IList<IconEntry> LoadFromJson(string pathToJson, string pathToGlyphList)
        {
            var inputText = System.IO.File.ReadAllText(pathToJson);
            var icons = (JObject)JsonConvert.DeserializeObject(inputText)!;

            List<IconEntry> iconEntries = new List<IconEntry>();
            foreach (var icon in icons)
            {
                if (icon.Value is null) continue;
                var name = icon.Key;
                var entry = new IconEntry() {
                    Key = name,

                    Alias = string.Join(", ", icon.Value["alias"]!.ToArray().Select(v => v.ToString())),
                    Category = icon.Value["category"]?.ToString(),
                    Release = icon.Value["release"]?.ToString(),
                    MultiPath = icon.Value["multiPath"]?.Value<bool>() == true,
                };
                iconEntries.Add(entry);
            }
            inputText = System.IO.File.ReadAllText(pathToGlyphList);
            var output = JsonConvert.DeserializeObject(inputText) as JObject;
            var codepoints = output!["codepoints"] as JObject ?? throw new InvalidOperationException("'codepoints' not found in json");
            foreach (var item in codepoints!)
            {
                var key = item.Key;
                bool isFilled = key.EndsWith("-f");
                if (isFilled)
                {
                    key = key.Substring(0, key.LastIndexOf('-'));
                }
                var name = key;
                var glyph = (ushort)item.Value;
                var entry = iconEntries.FirstOrDefault(f => f.Key  == name + (isFilled ? "-f" : ""));
                if(entry is null && isFilled) // Sometimes the filled version is missing. Find the non-filled version instead and clone it
                {
                    var entry2 = iconEntries.FirstOrDefault(f => f.Key == name);
                    if (entry2 is not null)
                    {
                        var filled = new IconEntry()
                        {
                            Key = name + "-f",
                            Alias = entry2.Alias + ", filled",
                            Category = entry2.Category,
                            Release = entry2.Release,
                            MultiPath = entry2.MultiPath,
                        };
                        iconEntries.Add(filled);
                        entry = filled;
                    }
                }
                if(entry is null)
                {
                    // A description of the icon wasn't found in keywords.json file
                    Console.WriteLine($"Warning: Codepoint {name}={glyph} does not have a matching icon entry");
                    entry = new IconEntry() { Key = name + (isFilled ? "-f" : "") };
                    iconEntries.Add(entry);
                }
                entry.Glyph = glyph;
            }
            List<string> missingIds = new List<string>();
            foreach (var entry in iconEntries.Where(e => e.Glyph == 0))
            {
                missingIds.Add(entry.Key);
            }
            iconEntries.RemoveAll(i=> i.Glyph == 0);
            Console.ResetColor();
            if (missingIds.Count > 0)
            {
                Console.WriteLine("*** Missing entries ***");
                Console.ForegroundColor = ConsoleColor.Yellow;
                var nextGlyphID = iconEntries.Max(i => i.Glyph) + 1;
                foreach(var id in missingIds.OrderBy(s=>s))
                {
                    Console.WriteLine($"    \"{id}\": {nextGlyphID++}, ");
                }
                Console.WriteLine("***");

                Console.ForegroundColor = ConsoleColor.Yellow;
                foreach (var id in missingIds.OrderBy(s => s))
                {
                    Console.WriteLine($"Warning: {id} is missing a glyph entry");
                }
                Console.ResetColor();
            }
            return iconEntries;
        }
        public bool IsFilled => Key.EndsWith("-f");
        public ushort Glyph { get; set; }
        public bool MultiPath { get; set; }
        public string Name
        {
            get
            {
                var name = Key;
                if (name.EndsWith("-f"))
                    name = name.Substring(0, name.LastIndexOf('-'));
                return Rename(name);
            }
        }
        private static string Rename(string name)
        {
            switch(name)
            {
                case "1-2x": return "one-half-times";
                case "1-4x": return "one-fourth-times";
                case "1-8x": return "one-eighth-times";
                case "1x": return "one-time";
                case "2x": return "two-times";
                case "4x": return "four-times";
                case "8x": return "eigth-times";
            }
            return name;
        }
        public string ResourceName => CamelCase(Name, true) + (IsFilled ? "Filled" : "");
        public required string Key { get; set; }
        public string CSName
        {
            get
            {
                string csname = CamelCase(Name, true);
                //if(csname.StartsWith("2d"))
                //    csname = "2D" + csname.Substring(2);
                //else if (csname.StartsWith("3d"))
                //    csname = "3D" + csname.Substring(2);
                if (csname[0] >= '0' && csname[0] <= '9')
                    csname = '_' + csname;
                if (IsFilled)
                    csname += "Filled";
                return csname;
            }
        }
        public string PrettyName
        {
            get
            {
                switch(Name)
                {
                    case "one-half-times": return "1/2x";
                    case "one-fourth-times": return "1/4x";
                    case "one-eighth-times": return "1/8x";
                    case "one-time": return "1x";
                    case "two-times": return "2x";
                    case "four-times": return "4x";
                    case "eigth-times": return "8x";
                    default:
                        return CamelCase(Name, false) + (IsFilled ? " (Filled)" : "");
                }
                
            }
        }
        public string? Alias { get; set; }
        public string? Category { get; set; }
        public string? Release { get; set; }

        static string CamelCase(string name, bool SkipSpaces)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < name.Length; i++)
            {
                if (name.StartsWith("2d"))
                    name = "2D" + name.Substring(2);
                else if (name.StartsWith("3d"))
                    name = "3D" + name.Substring(2);
                bool uppercase = false;
                if (i == 0)
                    uppercase = true;
                else if (name[i] == '_' || name[i] == '-')
                {
                    i++;
                    uppercase = true;
                    if (!SkipSpaces)
                        sb.Append(' ');
                }
                else if (i > 0 && name[i - 1] >= '0' && name[i - 1] <= '9')
                {
                    uppercase = true;
                }
                if (name.Contains("arcgis", StringComparison.OrdinalIgnoreCase))
                    name = name.Replace("arcgis", "ArcGIS");
                if (uppercase)
                    sb.Append(name[i].ToString().ToUpper());
                else
                    sb.Append(name[i]);
            }
            return sb.ToString();
        }
    }
}
