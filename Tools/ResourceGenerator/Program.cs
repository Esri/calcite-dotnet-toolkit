using Carbon.Css;
using IconXamlGenerator;

var pathToJson = args[0];
var pathToGlyphList = args[1];
var colorsSccs = args[2];
var pathToOutput = args[3];
var format = args[4];

var icons = IconEntry.LoadFromJson(pathToJson, pathToGlyphList);

if(!Directory.Exists(pathToOutput))
    Directory.CreateDirectory(pathToOutput);
if(!Directory.Exists(Path.Combine(pathToOutput, "Colors")))
    Directory.CreateDirectory(Path.Combine(pathToOutput, "Colors"));

GenerateColors(colorsSccs, Path.Combine(pathToOutput, "Colors"), format);

if(!Directory.Exists(Path.Combine(pathToOutput, "Icons")))
    Directory.CreateDirectory(Path.Combine(pathToOutput, "Icons"));
//GenerateIconsXaml(icons, Path.Combine(pathToOutput, "Icons", $"Icons.xaml"), format);
GenerateGlyphsXaml(icons, Path.Combine(pathToOutput, "Icons", "Glyphs.xaml"), format);
GenerateCalciteIconEnum(icons, Path.Combine(pathToOutput, $"Icons.cs"), "Esri.Calcite." + format);
GenerateCalciteHelper(icons, Path.Combine(pathToOutput, $"IconHelpers.cs"), "Esri.Calcite." + format);

void GenerateColors(string colorsScss, string pathToOutput, string format)
{
    var scss = StyleSheet.FromFile(new FileInfo(colorsScss));
    var darkColors = new Dictionary<string, CssAssignment>();
    var lightColors = new Dictionary<string, CssAssignment>();
    string xamlHeader = GetXamlHeader(format);
    using StreamWriter xamlOutput = new StreamWriter(Path.Combine(pathToOutput, "Colors.xaml"));
    xamlOutput.WriteLine(xamlHeader);
    Func<string, string, string> toResourceName = (cssname, resourceType) => {
        if(cssname.StartsWith("ui-foreground-"))
        {
            // Foreground colors are actually background colors
            // meant for cards, panels etc. This is confusing in a XAML context
            // where 'foreground' is usally referring to text color so renaming
            // the color resources here
            cssname = cssname.Replace("ui-foreground-", "ui-background-");
        }
        var parts = cssname.Replace("ui-", "UI-").Split("-");
        var name = string.Join("", parts.Select(p =>
         p switch {
             "v" => "ChartVibrant",
             "h" => "ChartHigh",
             "m" => "ChartMedium",
             "l" => "ChartLow",
             "d" => "ChartDark",
             "blk" => "ChartGray",
             "bb" => "Blue",
             "br" => "Brown",
             "gb" => "GreenBlue",
             "gg" => "Green",
             "yg" => "YellowGreen",
             "yy" => "Yellow",
             "oy" => "OrangeYellow",
             "oo" => "Orange",
             "ro" => "RedOrange",
             "rr" => "Red",
             "pk" => "Pink",
             "vr"=> "VioletRed",
             "vv" => "Violet",
             _ => p.Substring(0, 1).ToUpper() + p.Substring(1)
         }));
        return $"Calcite{name}{resourceType}";
    };
    foreach (var c in scss.Children.OfType<CssAssignment>())
    {
        if (c.Name.EndsWith("-dark"))
            darkColors.Add(c.Name, c);
        if (c.Name.EndsWith("-light"))
            lightColors.Add(c.Name, c);
        xamlOutput.WriteLine($"    <Color x:Key=\"{toResourceName(c.Name, "Color")}\">{c.Value}</Color>");
        xamlOutput.Flush();
    }
    if (format == "WinUI" || format == "UWP")
    {
        xamlOutput.WriteLine("    <ResourceDictionary.ThemeDictionaries>");
        xamlOutput.WriteLine("        <ResourceDictionary x:Key =\"Default\" >");
        foreach (var c in darkColors)
        {
            xamlOutput.WriteLine($"            <StaticResource x:Key=\"{toResourceName(c.Key.Replace("-dark", ""), "Color")}\" ResourceKey=\"{toResourceName(c.Key, "Color")}\" />");
        }
        xamlOutput.WriteLine("        </ResourceDictionary>");
        xamlOutput.WriteLine("        <ResourceDictionary x:Key =\"Light\" >");
        foreach (var c in lightColors)
        {
            xamlOutput.WriteLine($"            <StaticResource x:Key=\"{toResourceName(c.Key.Replace("-light",""), "Color")}\" ResourceKey=\"{toResourceName(c.Key, "Color")}\" />");
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
        Action<Dictionary<string, CssAssignment>, string> writeXaml = (colors, filename) =>
        {
            using StreamWriter output = new StreamWriter(Path.Combine(pathToOutput, filename));
            output.WriteLine(xamlHeader);
            foreach (var c in colors)
            {
                var name = c.Key.Replace("-dark", "").Replace("-light", "");
                output.WriteLine($"    <Color x:Key=\"{toResourceName(name, "Color")}\">{c.Value.Value}</Color>");
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
    else if(format == "Maui")
        brushOutput.WriteLine($"        <ResourceDictionary Source=\"Colors.xaml\" />");
    brushOutput.WriteLine("    </ResourceDictionary.MergedDictionaries>");
    foreach (var dark in darkColors)
    {
        var name = dark.Key.Replace("-dark", "");
        if (!lightColors.ContainsKey(name + "-light")) continue;
        var light = lightColors[name + "-light"];
        if (format == "Maui")
            brushOutput.WriteLine($"    <SolidColorBrush x:Key=\"{toResourceName(name, "Brush")}\" Color=\"{{AppThemeBinding Dark={{StaticResource {toResourceName(dark.Key, "Color")}}}, Light={{StaticResource {toResourceName(name + "-light", "Color")}}}}}\" />");
        else if(format == "WPF")
            brushOutput.WriteLine($"    <SolidColorBrush x:Key=\"{toResourceName(name, "Brush")}\" Color=\"{{DynamicResource {toResourceName(name, "Color")}}}\" />");
        else
            brushOutput.WriteLine($"    <SolidColorBrush x:Key=\"{toResourceName(name, "Brush")}\" Color=\"{{StaticResource {toResourceName(name, "Color")}}}\" />");
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