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
            var output = (JObject)JsonConvert.DeserializeObject(inputText)!;

            JObject icons = (JObject)(output["icons"] ?? throw new InvalidOperationException("'icons' not found in json"));
            List<IconEntry> iconEntries = new List<IconEntry>();
            foreach (var icon in icons)
            {
                if (icon.Value is null) continue;
                var name = icon.Key;
                var entry = new IconEntry() {
                    Key = name,

                    S16 = icon.Value["16"]?.ToString() ?? throw new InvalidOperationException("'16' not found in json"),
                    S24 = icon.Value["24"]?.ToString() ?? throw new InvalidOperationException("'24' not found in json"),
                    S32 = icon.Value["32"]?.ToString() ?? throw new InvalidOperationException("'32' not found in json"),
                    Alias = string.Join(", ", icon.Value["alias"]!.ToArray().Select(v => v.ToString())),
                    Category = icon.Value["category"]?.ToString(),
                    Release = icon.Value["release"]?.ToString(),
                    MultiPath = icon.Value["multiPath"]?.Value<bool>() == true,
                };
                iconEntries.Add(entry);
            }
            inputText = System.IO.File.ReadAllText(pathToGlyphList);
            output = JsonConvert.DeserializeObject(inputText) as JObject;
            var codepoints = output!["codepoints"] as JObject ?? throw new InvalidOperationException("'codepoints' not found in json");
            foreach (var item in codepoints!)
            {
                var key = item.Key;
                bool isFilled = key.EndsWith("-f");
                if (isFilled)
                {
                    key = key.Substring(0, key.LastIndexOf('-'));
                }
                var name = key.Substring(0, key.LastIndexOf('-'));
                var size = key.Substring(key.LastIndexOf('-') + 1);
                var glyph = (ushort)item.Value;
                var entry = iconEntries.FirstOrDefault(f => f.Key  == name + (isFilled ? "-f" : ""));
                if(entry is null)
                {
                    Console.WriteLine($"Warning: Codepoint {name}={glyph} does not have a matching icon entry");
                    continue;
                }
                if (size == "16")
                    entry.Glyph16 = glyph;
                else if (size == "24")
                    entry.Glyph24 = glyph;
                else if (size == "32")
                    entry.Glyph32 = glyph;
            }
            foreach (var entry in iconEntries)
            {
                if (entry.Glyph16 != entry.Glyph24 || entry.Glyph16 != entry.Glyph32 || entry.Glyph24 != entry.Glyph32)
                {
                    Console.WriteLine($"ERROR: {entry.Key} has different glyph values for 16, 24, and 32");
                    throw new Exception($"ERROR: {entry.Key} has different glyph values for 16, 24, and 32");
                }
            }
            List<string> missingIds = new List<string>();
            foreach (var entry in iconEntries)
            {
                if (entry.S16.Contains("opacity") || entry.S24.Contains("opacity") || entry.S32.Contains("opacity"))
                    continue; // Opacity icons not supported, so skipping those here

                if (entry.Glyph16 == 0 && !string.IsNullOrEmpty(entry.S16))
                {
                    missingIds.Add($"{entry.Key}-16");
                }
                if (entry.Glyph24 == 0 && !string.IsNullOrEmpty(entry.S24))
                {
                    missingIds.Add($"{entry.Key}-24");
                }
                if (entry.Glyph32 == 0 && !string.IsNullOrEmpty(entry.S32))
                {
                    missingIds.Add($"{entry.Key}-32");
                }
            }
            Console.ResetColor();
            if (missingIds.Count > 0)
            {
                Console.WriteLine("*** Missing entries ***");
                Console.ForegroundColor = ConsoleColor.Yellow;
                var nextGlyphID = iconEntries.Max(i => Math.Max(Math.Max(i.Glyph16, i.Glyph24), i.Glyph32)) + 1;
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
        public ushort Glyph16 { get; set; }
        public ushort Glyph24 { get; set; }
        public ushort Glyph32 { get; set; }
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
        public required string S16 { get; set; }
        public required string S24 { get; set; }
        public required string S32 { get; set; }
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
        public string PrettyName => CamelCase(Name, false) + (IsFilled ? " (Filled)" : "");
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
