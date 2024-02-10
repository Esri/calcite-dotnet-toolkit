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
            var output = JsonConvert.DeserializeObject(inputText) as JObject;

            JObject icons = (JObject)output["icons"];
            List<IconEntry> iconEntries = new List<IconEntry>();
            foreach (var icon in icons)
            {
                var name = icon.Key;
                var entry = new IconEntry() { Key = name };
                
                entry.S16 = icon.Value["16"].ToString();
                entry.S24 = icon.Value["24"].ToString();
                entry.S32 = icon.Value["32"].ToString();
                entry.Alias = string.Join(", ", icon.Value["alias"].ToArray().Select(v => v.ToString()));
                //entry.Alias = icon.Value["alias"]?.ToString().Replace("\n", ",");
                entry.Category = icon.Value["category"]?.ToString();
                entry.Release = icon.Value["release"]?.ToString();
                entry.MultiPath = icon.Value["multiPath"]?.Value<bool>() == true;
                iconEntries.Add(entry);
            }
            inputText = System.IO.File.ReadAllText(pathToGlyphList);
            output = JsonConvert.DeserializeObject(inputText) as JObject;
            var codepoints = output["codepoints"] as JObject;
            foreach(var item in codepoints!)
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
                    Console.WriteLine($"Warning: Codepoint {name}={glyph} does not have a matching SVG");
                    continue;
                }
                if (size == "16")
                    entry.Glyph16 = glyph;
                else if (size == "24")
                    entry.Glyph24 = glyph;
                else if (size == "32")
                    entry.Glyph32 = glyph;
            }
            bool hasErrors = false;
            foreach (var entry in iconEntries)
            {
                if (entry.Glyph16 == 0 && !string.IsNullOrEmpty(entry.S16))
                {
                    hasErrors = true;
                    Console.WriteLine($"ERROR: {entry.Key}-16 is missing a codepoint");
                }
                else if (entry.Glyph24 == 0 && !string.IsNullOrEmpty(entry.S24))
                {
                    hasErrors = true;
                    Console.WriteLine($"ERROR: {entry.Key}-24 is missing a codepoint");
                }
                else if (entry.Glyph32 == 0 && !string.IsNullOrEmpty(entry.S32))
                {
                    hasErrors = true;
                    Console.WriteLine($"ERROR: {entry.Key}-32 is missing a codepoint");
                }
            }
            if (hasErrors)
                throw new InvalidOperationException();
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
        public string Key { get; set; }
        public string S16 { get; set; }
        public string S24 { get; set; }
        public string S32 { get; set; }
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
        public string Alias { get; set; }
        public string Category { get; set; }
        public string Release { get; set; }

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
                if (uppercase)
                    sb.Append(name[i].ToString().ToUpper());
                else
                    sb.Append(name[i]);
            }
            return sb.ToString();
        }
    }
}
