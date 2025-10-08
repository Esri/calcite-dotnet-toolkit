// COPYRIGHT © 2025 Esri
// All rights reserved under the copyright laws of the United States and applicable international laws, treaties, and conventions.
// This material is licensed for use under the Esri Master License Agreement (MLA), and is bound by the terms of that agreement.
// You may redistribute and use this code without modification, provided you adhere to the terms of the MLA and include this copyright notice.
//
// See use restrictions at http://www.esri.com/legal/pdfs/mla_e204_e300/english
//
// For additional information, contact: Environmental Systems Research Institute, Inc.
// Attn: Contracts and Legal Services Department 380 New York Street Redlands, California, USA 92373 USA. email: contracts@esri.com

using IconXamlGenerator;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

const string FileHeader = """
// COPYRIGHT © 2025 Esri
// All rights reserved under the copyright laws of the United States and applicable international laws, treaties, and conventions.
// This material is licensed for use under the Esri Master License Agreement (MLA), and is bound by the terms of that agreement.
// You may redistribute and use this code without modification, provided you adhere to the terms of the MLA and include this copyright notice.
//
// See use restrictions at http://www.esri.com/legal/pdfs/mla_e204_e300/english
//
// For additional information, contact: Environmental Systems Research Institute, Inc.
// Attn: Contracts and Legal Services Department 380 New York Street Redlands, California, USA 92373 USA. email: contracts@esri.com

""";

var pathToJson = args[0];
var pathToGlyphList = args[1];
var designTokens = args[2];
var pathToOutput = args[3];
var format = args[4];

var icons = IconEntry.LoadFromJson(pathToJson, pathToGlyphList);

if(!Directory.Exists(pathToOutput))
    Directory.CreateDirectory(pathToOutput);
if(!Directory.Exists(Path.Combine(pathToOutput, "Colors")))
    Directory.CreateDirectory(Path.Combine(pathToOutput, "Colors"));


GenerateColors(designTokens, Path.Combine(pathToOutput, "Colors"), format);

if(!Directory.Exists(Path.Combine(pathToOutput, "Icons")))
    Directory.CreateDirectory(Path.Combine(pathToOutput, "Icons"));
//GenerateIconsXaml(icons, Path.Combine(pathToOutput, "Icons", $"Icons.xaml"), format);
GenerateGlyphsXaml(icons, Path.Combine(pathToOutput, "Icons", "Glyphs.xaml"), format);
GenerateCalciteIconEnum(icons, Path.Combine(pathToOutput, $"CalciteIcon.cs"), "Esri.Calcite." + format);
GenerateCalciteHelper(icons, Path.Combine(pathToOutput, $"IconHelpers.cs"), "Esri.Calcite." + format);


void GenerateColors(string pathToDesignTokensRepo, string pathToOutput, string format)
{
    var darkColors = new Dictionary<string, string>();
    var lightColors = new Dictionary<string, string>();
    string xamlHeader = GetXamlHeader(format);
    using StreamWriter xamlOutput = new StreamWriter(Path.Combine(pathToOutput, "Colors.xaml"));
    xamlOutput.WriteLine(xamlHeader);

    var colors = ResourceGenerator.DesignTokens.GenerateDesignTokens(pathToDesignTokensRepo);

    Func<string, string, string> toResourceName = (name, resourceType) =>
    {
        if (name.StartsWith("Foreground"))
        {
            // Foreground colors are actually background colors
            // meant for cards, panels etc. This is confusing in a XAML context
            // where 'foreground' is usally referring to text color so renaming
            // the color resources here
            name = name.Replace("Foreground", "Background");
        }
        return $"Calcite{name}{resourceType}";
    };

    foreach (var color in colors.OrderBy(c => c.DesignTokenId).Where(c=>c.Type == ResourceGenerator.DesignTokens.ColorType.Core).Concat(colors.OrderBy(c => c.DesignTokenId + c.Type.ToString()).Where(c => c.Type != ResourceGenerator.DesignTokens.ColorType.Core)))
    {
        if (color.Type == ResourceGenerator.DesignTokens.ColorType.SemanticDark)
        {
            darkColors.Add(color.ResourceId, color.Value);
            xamlOutput.WriteLine($"    <Color x:Key=\"{toResourceName(color.ResourceId, "DarkColor")}\">{color.Value}</Color>");
        }
        else if (color.Type == ResourceGenerator.DesignTokens.ColorType.SemanticLight)
        {
            lightColors.Add(color.ResourceId, color.Value);
            xamlOutput.WriteLine($"    <Color x:Key=\"{toResourceName(color.ResourceId, "LightColor")}\">{color.Value}</Color>");
        }
        else
        {
            xamlOutput.WriteLine($"    <Color x:Key=\"{toResourceName(color.ResourceId, "Color")}\">{color.Value}</Color>");
            xamlOutput.Flush();
        }
    }
    if (format == "WinUI" || format == "UWP")
    {
        xamlOutput.WriteLine("    <ResourceDictionary.ThemeDictionaries>");
        xamlOutput.WriteLine("        <ResourceDictionary x:Key =\"Default\" >");
        foreach (var c in darkColors)
        {
            xamlOutput.WriteLine($"            <StaticResource x:Key=\"{toResourceName(c.Key, "Color")}\" ResourceKey=\"{toResourceName(c.Key, "DarkColor")}\" />");
        }
        xamlOutput.WriteLine("        </ResourceDictionary>");
        xamlOutput.WriteLine("        <ResourceDictionary x:Key =\"Light\" >");
        foreach (var c in lightColors)
        {
            xamlOutput.WriteLine($"            <StaticResource x:Key=\"{toResourceName(c.Key, "Color")}\" ResourceKey=\"{toResourceName(c.Key, "LightColor")}\" />");
        }
        xamlOutput.WriteLine("        </ResourceDictionary>");
        xamlOutput.WriteLine("    </ResourceDictionary.ThemeDictionaries>");
    }
    xamlOutput.WriteLine("</ResourceDictionary>");
    xamlOutput.Flush();
    xamlOutput.Close();
    xamlOutput.Dispose();

    if (format == "WPF")
    {
        Action<Dictionary<string, string>, string> writeXaml = (colors, filename) =>
        {
            using StreamWriter output = new StreamWriter(Path.Combine(pathToOutput, filename));
            output.WriteLine(xamlHeader);
            foreach (var c in colors)
            {
                var name = c.Key.Replace("-dark", "").Replace("-light", "");
                output.WriteLine($"    <Color x:Key=\"{toResourceName(name, "Color")}\">{c.Value}</Color>");
                output.Flush();
            }
            output.WriteLine("</ResourceDictionary>");
            output.Flush();
            output.Dispose();
        };
        writeXaml(darkColors, "Colors.Dark.xaml");
        writeXaml(lightColors, "Colors.Light.xaml");
    }
    // Brushes
    using var brushOutput = new StreamWriter(Path.Combine(pathToOutput, "Brushes.xaml"));
    brushOutput.WriteLine(xamlHeader);
    brushOutput.WriteLine("    <ResourceDictionary.MergedDictionaries>");
    if (format == "WinUI" || format == "UWP")
        brushOutput.WriteLine($"        <ResourceDictionary Source=\"ms-appx:///Esri.Calcite.{format}/Colors/Colors.xaml\" />");
    else if (format == "Maui")
        brushOutput.WriteLine($"        <ResourceDictionary Source=\"Colors.xaml\" />");
    brushOutput.WriteLine("    </ResourceDictionary.MergedDictionaries>");
    foreach (var dark in darkColors)
    {
        var name = dark.Key;
        if (!lightColors.ContainsKey(name)) continue;
        var light = lightColors[name];
        if (format == "Maui")
            brushOutput.WriteLine($"    <SolidColorBrush x:Key=\"{toResourceName(name, "Brush")}\" Color=\"{{AppThemeBinding Dark={{StaticResource {toResourceName(dark.Key, "DarkColor")}}}, Light={{StaticResource {toResourceName(name, "LightColor")}}}}}\" />");
        else if(format == "WPF")
            brushOutput.WriteLine($"    <SolidColorBrush x:Key=\"{toResourceName(name, "Brush")}\" Color=\"{{DynamicResource {toResourceName(name, "Color")}}}\" />");
        else if(format == "WinUI" || format == "UWP")
            brushOutput.WriteLine($"            <SolidColorBrush x:Key=\"{toResourceName(name, "Brush")}\" Color=\"{{ThemeResource {toResourceName(name, "Color")}}}\" />");
    }
    brushOutput.WriteLine("</ResourceDictionary>");
    brushOutput.Flush();
    brushOutput.Dispose();
}

static string GetXamlHeader(string format)
{
    if (format == "WPF")
        return "<ResourceDictionary\n    xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\"\n    xmlns:x=\"http://schemas.microsoft.com/winfx/2006/xaml\"\n    xmlns:system=\"clr-namespace:System;assembly=mscorlib\">";
    if (format == "WinUI" || format == "UWP")
        return "<ResourceDictionary\n    xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\" xmlns:x=\"http://schemas.microsoft.com/winfx/2006/xaml\">";
    else if (format == "Maui")
        return "<?xml version=\"1.0\" encoding=\"UTF-8\" ?><?xaml-comp compile=\"true\" ?><ResourceDictionary\n    xmlns=\"http://schemas.microsoft.com/dotnet/2021/maui\"\n    xmlns:x=\"http://schemas.microsoft.com/winfx/2009/xaml\">";
    throw new NotSupportedException("Fomat " + format);
}
void GenerateGlyphsXaml(IList<IconEntry> icons, string filename, string format)
{
    string xamlHeader = GetXamlHeader(format);
    string xamlType = format == "WPF" ? "system:String" : "x:String";
    using StreamWriter xamlOutput = new StreamWriter(filename);
    xamlOutput.WriteLine(xamlHeader);
    foreach (var icon in icons.OrderBy(i=>i.Name))
    {
        xamlOutput.WriteLine($"    <{xamlType} x:Key=\"CalciteUIIcons_Glyph_{icon.ResourceName}\">&#x{icon.Glyph.ToString("x4")};</{xamlType}> ");
        xamlOutput.Flush();
    }
    xamlOutput.WriteLine("</ResourceDictionary>");
    xamlOutput.Flush();
    xamlOutput.Dispose();
}
/*
void GenerateIconsXaml(IList<IconEntry> icons, string filename, string format)
{
    string xamlHeader = "<ResourceDictionary xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\" xmlns:x=\"http://schemas.microsoft.com/winfx/2006/xaml\">";
    if (format == "WinUI" || format == "UWP")
        xamlHeader = "<ResourceDictionary xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\" xmlns:x=\"http://schemas.microsoft.com/winfx/2006/xaml\">";
    else if (format == "Maui")
        xamlHeader = "<?xml version=\"1.0\" encoding=\"UTF-8\" ?><?xaml-comp compile=\"true\" ?><ResourceDictionary xmlns=\"http://schemas.microsoft.com/dotnet/2021/maui\" xmlns:x=\"http://schemas.microsoft.com/winfx/2009/xaml\">";
    string xamlFooter = "</ResourceDictionary>";
    using StreamWriter xamlOutput = new StreamWriter(filename);
    xamlOutput.WriteLine(xamlHeader);
    foreach (var icon in icons)
    {
        var name = icon.Name;
        if (icon.MultiPath)
        {
            Console.WriteLine(name);
            continue;
        }
        string xaml = "";
        foreach (var size in new[] { "16", "24", "32" })
        {
            var path = size == "16" ? icon.S16 : size == "24" ? icon.S24 : icon.S32;
            if (string.IsNullOrWhiteSpace(path))
            {
                continue;
            }

            if (format == "Maui")
                xaml = $"\t<PathGeometry x:Key=\"Calcite_GeometryIcon_{icon.ResourceName}_{size}\" Figures=\"{path}\" />";
            else if (format == "WinUI" || format == "UWP")
            {
                // WinUI PathGeometries can't be shared due to https://github.com/microsoft/microsoft-ui-xaml/issues/5780#issuecomment-921508417
                // Instead we just use the string and re-parse it each time
                xaml = $"\t<x:String x:Key=\"Calcite_GeometryString_{icon.ResourceName}_{size}\">{path}</x:String>{System.Environment.NewLine}";
                xaml += $"\t<PathIconSource x:Key=\"Calcite_PathIcon_{icon.ResourceName}_{size}\" Data=\"{path}\" />";
            }
            else
                xaml = $"\t<Geometry x:Key=\"Calcite_GeometryIcon_{icon.ResourceName}_{size}\">{path}</Geometry>";

            xamlOutput.WriteLine(xaml);
            xamlOutput.Flush();
        }
        string? alias = icon.Alias.Replace(Environment.NewLine, "");
    }
    xamlOutput.WriteLine(xamlFooter);
    xamlOutput.Flush();
    xamlOutput.Dispose();
}
*/
void GenerateCalciteIconEnum(IList<IconEntry> icons, string filename, string _namespace)
{
    using StreamWriter iconsEnumOutput = new StreamWriter(filename);
    iconsEnumOutput.WriteLine(FileHeader);
    iconsEnumOutput.WriteLine($"namespace {_namespace};");
    iconsEnumOutput.WriteLine();
    iconsEnumOutput.WriteLine("/// <summary>A collection of Calcite UI Icons.</summary>");
    iconsEnumOutput.WriteLine("/// <remarks>The enum <c>UInt16</c> values correspond to the character code in the Calcite symbol font.</remarks>");
    iconsEnumOutput.WriteLine("public enum CalciteIcon : ushort");
    iconsEnumOutput.WriteLine("{");

    foreach (var icon in icons.OrderBy(i=>i.Glyph))
    {   
        string? alias = icon.Alias?.Replace(Environment.NewLine, "");
        iconsEnumOutput.WriteLine($"\t/// <summary>{icon.PrettyName}</summary>");
        if(!string.IsNullOrEmpty(icon.Category))
            iconsEnumOutput.WriteLine($"\t/// <remarks>Category: {icon.Category}<br/>\n\t/// Alias: {alias}</remarks>");
        if (!string.IsNullOrEmpty(icon.Release))
            iconsEnumOutput.WriteLine($"\t/// <release>{icon.Release}</release>");
        iconsEnumOutput.WriteLine($"\t{icon.CSName} = {icon.Glyph},");
        iconsEnumOutput.WriteLine();
        iconsEnumOutput.Flush();
    }

    iconsEnumOutput.WriteLine("}");
    iconsEnumOutput.Flush();
    iconsEnumOutput.Dispose();
}

static void GenerateCalciteHelper(IList<IconEntry> icons, string filename, string _namespace)
{
    using StreamWriter iconHelpersOutput = new StreamWriter(filename);
    iconHelpersOutput.WriteLine(FileHeader);
    iconHelpersOutput.WriteLine($"namespace {_namespace};");
    iconHelpersOutput.WriteLine();
    iconHelpersOutput.WriteLine("internal static class IconHelpers");
    iconHelpersOutput.WriteLine("{");
    iconHelpersOutput.WriteLine("\tpublic static string ToResourceName(CalciteIcon icon)");
    iconHelpersOutput.WriteLine("\t{");
    iconHelpersOutput.WriteLine("\t\tswitch(icon)");
    iconHelpersOutput.WriteLine("\t\t{");
    foreach (var icon in icons.OrderBy(i=>i.Glyph))
        iconHelpersOutput.WriteLine($"\t\t\tcase CalciteIcon.{icon.CSName}: return \"{icon.ResourceName}\";");

    iconHelpersOutput.WriteLine("\t\t}");
    iconHelpersOutput.WriteLine("\t\treturn \"\"; ");
    iconHelpersOutput.WriteLine("\t}");
    iconHelpersOutput.WriteLine("}");
    iconHelpersOutput.Flush();
    iconHelpersOutput.Dispose();
}
