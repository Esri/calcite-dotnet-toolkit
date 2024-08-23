# .NET MAUI

## Usage<a name="usage" />
Add the CalciteResources ResourceDictionary to your App.xaml Merged Directionary resources inside the default `XamlControlsResources` to get access
to default styles and resources. Dark/Light mode is automatically handled and adjust to system or app settings.


```xml
    <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <ResourceDictionary Source="Resources/Styles/Colors.xaml" />
                <ResourceDictionary Source="Resources/Styles/Styles.xaml" />
                <CalciteResources xmlns="http://schemas.esri.com/calcite/2024"/>
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Application.Resources>
```
Next register Calcite in `MauiProgram.cs`:
```cs
using Esri.Calcite.Maui;

namespace MauiTests
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                }).UseCalcite(); // Register Calcite

            return builder.Build();
        }
    }
}
```
If you don't want the default implicit Calcite styles, place the `CalciteResources` entry in App.xaml right before the `Styles.xaml` entry.

## Using Brush resources

Brushes and colors can be referenced as static resources.

```xml
<Border Background="{StaticResource CalciteUIBrandBrush}">
  <Label Text="Hello Calcite" TextColor="{AppThemeBinding Light={StaticResource CalciteUITextInverseLightColor}, Dark={StaticResource CalciteUITextInverseDarkColor}}" />
</Border>
```

## Symbol Font
`CalciteUIIconsFontFamily` FontFamily is a font with a set of symbols generated from the [Calcite UI Icons repo](https://github.com/Esri/calcite-ui-icons).
This font FontFamily can directly be referred to by its name `CalciteUIIconsFontFamily`.

Example:
```xml
<Label Text="{StaticResource CalciteUIIcons_Glyph_Map_24}" 
	   FontFamily="CalciteUIIconsFontFamily" />
```

For a full list of Glyph Resource IDs refer to the sample apps and the [Calcite-UI-Icons](https://github.com/Esri/calcite-ui-icons) repo.


# Markup Extensions

`CalciteIconImageSource` : Converts an Icon to an Image Source. Example:
```xml
<Image>
    <Image.Source>
        <calcite:CalciteIconImageSource Color="Blue" Icon="MagnifyingGlass" Size="40" Scale="Large" />
    </Image.Source>
</Image>
```

`CalciteIconImageExtension` : Markup extension converting an Icon to an `CalciteIconImageSource`. Example:
```xml
<Image Source="{calcite:CalciteIconImage Color=Blue, Icon=MagnifyingGlass,Size=40, Scale=Large}" />
```