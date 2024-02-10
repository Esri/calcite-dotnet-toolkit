using IconXamlGenerator;

var pathToJson = args[0];
var pathToGlyphList = args[1];
var pathToOutput = args[2];
var format = args[3];

var icons = IconEntry.LoadFromJson(pathToJson, pathToGlyphList);

if(!Directory.Exists(pathToOutput))
    Directory.CreateDirectory(pathToOutput);

//GenerateIconsXaml(icons, Path.Combine(pathToOutput, $"Icons.xaml"), format);
GenerateGlyphsXaml(icons, Path.Combine(pathToOutput, $"Glyphs.xaml"), format);
GenerateCalciteIconEnum(icons, Path.Combine(pathToOutput, $"Icons.cs"), "Esri.Calcite." + format);
GenerateCalciteHelper(icons, Path.Combine(pathToOutput, $"IconHelpers.cs"), "Esri.Calcite." + format);

void GenerateGlyphsXaml(IList<IconEntry> icons, string filename, string format)
{
    string xamlHeader = "<ResourceDictionary\n    xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\"\n    xmlns:x=\"http://schemas.microsoft.com/winfx/2006/xaml\"\n    xmlns:system=\"clr-namespace:System;assembly=mscorlib\">";
    if (format == "WinUI" || format == "UWP")
        xamlHeader = "<ResourceDictionary\n    xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\" xmlns:x=\"http://schemas.microsoft.com/winfx/2006/xaml\">";
    else if (format == "Maui")
        xamlHeader = "<?xml version=\"1.0\" encoding=\"UTF-8\" ?><?xaml-comp compile=\"true\" ?><ResourceDictionary\n    xmlns=\"http://schemas.microsoft.com/dotnet/2021/maui\"\n    xmlns:x=\"http://schemas.microsoft.com/winfx/2009/xaml\">";
    string xamlType = format == "WPF" ? "system:String" : "x:String";
    using StreamWriter xamlOutput = new StreamWriter(filename);
    xamlOutput.WriteLine(xamlHeader);
    foreach (var icon in icons)
    {
        xamlOutput.WriteLine($"    <{xamlType} x:Key=\"Calcite_UIIcons_Glyph_{icon.ResourceName}_16\">&#x{icon.Glyph16.ToString("x4")};</{xamlType}> ");
        xamlOutput.WriteLine($"    <{xamlType} x:Key=\"Calcite_UIIcons_Glyph_{icon.ResourceName}_24\">&#x{icon.Glyph24.ToString("x4")};</{xamlType}>");
        xamlOutput.WriteLine($"    <{xamlType} x:Key=\"Calcite_UIIcons_Glyph_{icon.ResourceName}_32\">&#x{icon.Glyph32.ToString("x4")};</{xamlType}>");
        xamlOutput.Flush();
    }
    xamlOutput.WriteLine("</ResourceDictionary>");
    xamlOutput.Flush();
    xamlOutput.Dispose();
}

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

void GenerateCalciteIconEnum(IList<IconEntry> icons, string filename, string _namespace)
{
    using StreamWriter iconsEnumOutput = new StreamWriter(filename);
    iconsEnumOutput.WriteLine($"namespace {_namespace};");
    iconsEnumOutput.WriteLine();
    iconsEnumOutput.WriteLine("public enum CalciteIcon : ushort");
    iconsEnumOutput.WriteLine("{");

    foreach (var icon in icons)
    {   
        string? alias = icon.Alias.Replace(Environment.NewLine, "");
        iconsEnumOutput.WriteLine($"\t/// <summary>{icon.PrettyName}</summary>");
        iconsEnumOutput.WriteLine($"\t/// <remarks>Category: {icon.Category}<br/>\n\t/// Alias: {alias}</remarks>");
        iconsEnumOutput.WriteLine($"\t/// <release>{icon.Release}</release>");
        iconsEnumOutput.WriteLine($"\t{icon.CSName} = {icon.Glyph16},");
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

    iconHelpersOutput.WriteLine($"namespace {_namespace};");
    iconHelpersOutput.WriteLine();
    iconHelpersOutput.WriteLine("internal static class IconHelpers");
    iconHelpersOutput.WriteLine("{");
    iconHelpersOutput.WriteLine("\tpublic static string ToResourceName(CalciteIcon icon)");
    iconHelpersOutput.WriteLine("\t{");
    iconHelpersOutput.WriteLine("\t\tswitch(icon)");
    iconHelpersOutput.WriteLine("\t\t{");
    foreach (var icon in icons)
        iconHelpersOutput.WriteLine($"\t\t\tcase CalciteIcon.{icon.CSName}: return \"{icon.ResourceName}\";");

    iconHelpersOutput.WriteLine("\t\t}");
    iconHelpersOutput.WriteLine("\t\treturn \"\"; ");
    iconHelpersOutput.WriteLine("\t}");
    iconHelpersOutput.WriteLine("}");
    iconHelpersOutput.Flush();
    iconHelpersOutput.Dispose();
}