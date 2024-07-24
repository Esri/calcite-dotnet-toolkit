# Calcite
Unofficial implementation of the Esri Calcite styles for various .NET XAML Frameworks inspired by the [Calcite Design System](https://github.com/Esri/calcite-design-system).

## Index
 - [Usage](#usage)
 - [Color and Brush resources](#color-and-brush-resources)
 - [Symbol Font](#symbol-font)
 - [Extensions and helpers](#extensions-and-helpers)


## Usage<a name="usage" />
Add the CalciteResources ResourceDictionary to your App.xaml Merged Directionary resources to get access
to default styles and resources. Dark/Light mode is automatically handled and adjust to system or app settings.

### WPF

```xml
    <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <CalciteResources xmlns="http://schemas.esri.com/calcite/2024" Theme="Light" />
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Application.Resources>
```
### WinUI
```xml
    <ResourceDictionary.MergedDictionaries>
        <XamlControlsResources xmlns="using:Microsoft.UI.Xaml.Controls" >
            <XamlControlsResources.MergedDictionaries>
                <CalciteResources xmlns="using:Esri.Calcite.WinUI" />
            </XamlControlsResources.MergedDictionaries>
        </XamlControlsResources>
    </ResourceDictionary.MergedDictionaries>
```

### .NET MAUI

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

## Color and Brush resources
For brushes, replace the `Color` postfix with `Brush`.
Append `Dark` or `Light` before `Color` for dark and light mode colors (does not apply to brush resource keys which automatically update based on application theme).
See https://github.com/Esri/calcite-colors/ for more information about the predefined Calcite colors, as well as the [Calcite Colors & Theming documentation](https://developers.arcgis.com/calcite-design-system/foundations/colors/).

| Resource Key | Light Mode | Dark Mode |
| --- | --- | --- |
| CalciteUIBrandColor | ![#007AC2](https://placehold.co/15x15/007AC2/007AC2.png)`#007AC2` | ![#00619B](https://placehold.co/15x15/00619B/00619B.png)`#00619B` |
| CalciteUIBrandHoverColor | ![#00619B](https://placehold.co/15x15/00619B/00619B.png)`#00619B` | ![#007AC2](https://placehold.co/15x15/007AC2/007AC2.png)`#007AC2` |
| CalciteUIBrandPressColor | ![#004874](https://placehold.co/15x15/004874/004874.png)`#004874` | ![#00619B](https://placehold.co/15x15/00619B/00619B.png)`#00619B` |
| CalciteUIBackgroundColor | ![#F8F8F8](https://placehold.co/15x15/F8F8F8/F8F8F8.png)`#F8F8F8` | ![#353535](https://placehold.co/15x15/353535/353535.png)`#353535` |
| CalciteUIBackground1Color | ![#FFFFFF](https://placehold.co/15x15/FFFFFF/FFFFFF.png)`#FFFFFF` | ![#2B2B2B](https://placehold.co/15x15/2B2B2B/2B2B2B.png)`#2B2B2B` |
| CalciteUIBackground2Color | ![#F3F3F3](https://placehold.co/15x15/F3F3F3/F3F3F3.png)`#F3F3F3` | ![#202020](https://placehold.co/15x15/202020/202020.png)`#202020` |
| CalciteUIBackground3Color | ![#EAEAEA](https://placehold.co/15x15/EAEAEA/EAEAEA.png)`#EAEAEA` | ![#151515](https://placehold.co/15x15/151515/151515.png)`#151515` |
| CalciteUIText1Color | ![#151515](https://placehold.co/15x15/151515/151515.png)`#151515` | ![#FFFFFF](https://placehold.co/15x15/FFF/FFF.png)`#FFFFFF` |
| CalciteUIText2Color | ![#4A4A4A](https://placehold.co/15x15/4A4A4A/4A4A4A.png)`#4A4A4A` | ![#BFBFBF](https://placehold.co/15x15/BFBFBF/BFBFBF.png)`#BFBFBF` |
| CalciteUIText3Color | ![#6A6A6A](https://placehold.co/15x15/6A6A6A/6A6A6A.png)`#6A6A6A` | ![#9F9F9F](https://placehold.co/15x15/9F9F9F/9F9F9F.png)`#9F9F9F` |
| CalciteUITextHighlightColor | ![#BBD5FA](https://placehold.co/15x15/BBD5FA/BBD5FA.png)`#BBD5FA` | ![#375F95](https://placehold.co/15x15/375F95/375F95.png)`#375F95` |
| CalciteUITextInverseColor | ![#FFFFFF](https://placehold.co/15x15/FFF/FFF.png)`#FFFFFF` | ![#151515](https://placehold.co/15x15/151515/151515.png)`#151515` |
| CalciteUITextLinkColor | ![#00619B](https://placehold.co/15x15/00619B/00619B.png)`#00619B` | ![#00A0FF](https://placehold.co/15x15/00A0FF/00A0FF.png)`#00A0FF` |
| CalciteUIBorder1Color | ![#CACACA](https://placehold.co/15x15/CACACA/CACACA.png)`#CACACA` | ![#555555](https://placehold.co/15x15/555555/555555.png)`#555555` |
| CalciteUIBorder2Color | ![#D4D4D4](https://placehold.co/15x15/D4D4D4/D4D4D4.png)`#D4D4D4` | ![#4A4A4A](https://placehold.co/15x15/4A4A4A/4A4A4A.png)`#4A4A4A` |
| CalciteUIBorder3Color | ![#DFDFDF](https://placehold.co/15x15/DFDFDF/DFDFDF.png)`#DFDFDF` | ![#404040](https://placehold.co/15x15/404040/404040.png)`#404040` |
| CalciteUIBorderInputColor | ![#949494](https://placehold.co/15x15/949494/949494.png)`#949494` | ![#757575](https://placehold.co/15x15/757575/757575.png)`#757575` |
| CalciteUIInfoColor | ![#00619B](https://placehold.co/15x15/00619B/00619B.png)`#00619B` | ![#00A0FF](https://placehold.co/15x15/00A0FF/00A0FF.png)`#00A0FF` |
| CalciteUISuccessColor | ![#35AC46](https://placehold.co/15x15/35AC46/35AC46.png)`#35AC46` | ![#36DA43](https://placehold.co/15x15/36DA43/36DA43.png)`#36DA43` |
| CalciteUIWarningColor | ![#EDD317](https://placehold.co/15x15/EDD317/EDD317.png)`#EDD317` | ![#FFC900](https://placehold.co/15x15/FFC900/FFC900.png)`#FFC900` |
| CalciteUIDangerColor | ![#D83020](https://placehold.co/15x15/D83020/D83020.png)`#D83020` | ![#FE583E](https://placehold.co/15x15/FE583E/FE583E.png)`#FE583E` |
| CalciteUIDangerHoverColor | ![#A82B1E](https://placehold.co/15x15/A82B1E/A82B1E.png)`#A82B1E` | ![#FF0015](https://placehold.co/15x15/FF0015/FF0015.png)`#FF0015` |
| CalciteUIDangerPressColor | ![#7C1D13](https://placehold.co/15x15/7C1D13/7C1D13.png)`#7C1D13` | ![#D90012](https://placehold.co/15x15/D90012/D90012.png)`#D90012` |

#### Example WPF:
```xml
<Border Background="{StaticResource CalciteUIBrandBrush}">
  <TextBlock Text="Hello Calcite">
     <TextBlock.Foreground>
        <SolidColorBrush Color="{StaticResource CalciteUITextInverseColor} />
     </TextBlock.Foreground>
  </TextBlock>
</Border>
```
#### Example WinUI:
```xml
<Border Background="{ThemeResource CalciteUIBrandBrush}">
  <TextBlock Text="Hello Calcite">
     <TextBlock.Foreground>
        <SolidColorBrush Color="{ThemeResource CalciteUITextInverseColor} />
     </TextBlock.Foreground>
  </TextBlock>
</Border>
```
#### Example .NET MAUI:
```xml
<Border Background="{StaticResource CalciteUIBrandBrush}">
  <Label Text="Hello Calcite" TextColor="{AppThemeBinding Light={StaticResource CalciteUITextInverseLightColor}, Dark={StaticResource CalciteUITextInverseDarkColor}}" />
</Border>
```

## Symbol Font
`Calcite-UI-Icons` FontFamily is a font with a set of symbols generated from the [Calcite UI Icons repo](https://github.com/Esri/calcite-ui-icons).
In WPF and WinUI this font can be referred to with the resource key `Calcite-UI-Icons`.
In .NET MAUI the FontFamily can directly be referred to by its name `calcite-ui-icons`.

### WPF and WinUI:
```xml
<TextBlock Text="{StaticResource Calcite_UIIcons_Glyph_Map_24}" 
           FontFamily="{StaticResource Calcite-UI-Icons}" />
```
### .NET MAUI:
```xml
<Label Text="{StaticResource Calcite_UIIcons_Glyph_Map_24}" 
	   FontFamily="calcite-ui-icons" />
```

For a fill list of Glyph Resource IDs refer to the sample apps and the [Calcite-UI-Icons](https://github.com/Esri/calcite-ui-icons) repo.


# Extensions and helpers

## WPF
#### Markup Extensions:
`CalciteIconGeometryExtension` : Convert an Icon to a Path Geometry. Example:
```xml
<Path Data="{calcite:CalciteIconGeometry Icon=ChevronLeft, Scale=Small}" Fill="Green" Width="32" Height="32" Stretch="Uniform" />
```

`CalciteIconImageExtension` : Convert an Icon to an Image Source. Example:
```xml
<Image Source="{calcite:CalciteIconImage Icon=AddLayer, Scale=Large, SymbolSize=32, Brush=Blue}" Width="32" Height="32" />
```

## WinUI
`CalciteFontIconSource` : Converts an Icon to an IconSource. Example:
```
  <IconSourceElement Width="32" Height="32" >
      <IconSourceElement.IconSource>
          <cal:CalciteFontIconSource Icon="Map" FontSize="32" Scale="Large" />
      </IconSourceElement.IconSource>
  </IconSourceElement>
```
Using in AppBarButtons in a command bar:
```xml
  <CommandBar IsOpen="True">
      <CommandBar.PrimaryCommands>
          <AppBarButton Label="Zoom In">
              <AppBarButton.Icon>
                  <IconSourceElement >
                      <IconSourceElement.IconSource>
                          <cal:CalciteFontIconSource Icon="ZoomInFixed" FontSize="16" Scale="Small" />
                      </IconSourceElement.IconSource>
                  </IconSourceElement>
              </AppBarButton.Icon>
          </AppBarButton>
          <AppBarButton Label="Zoom Out">
              <AppBarButton.Icon>
                  <IconSourceElement >
                      <IconSourceElement.IconSource>
                          <cal:CalciteFontIconSource Icon="ZoomOutFixed" FontSize="16" Scale="Small" />
                      </IconSourceElement.IconSource>
                  </IconSourceElement>
              </AppBarButton.Icon>
          </AppBarButton>
      </CommandBar.PrimaryCommands>
  </CommandBar>
```

The markup extensions `CalciteIconSourceElementExtension` and `CalciteIconSourceExtension` can simplify creating IconSourceElement and IconSource even further:
```xml
  <CommandBar IsOpen="True">
      <CommandBar.PrimaryCommands>
          <AppBarButton Label="Zoom In" Icon="{cal:CalciteIconSourceElement SymbolSize=22, Icon=ZoomInFixed, Scale=Small}" />
          <AppBarButton Label="Zoom Out">
              <AppBarButton.Icon>
                  <IconSourceElement IconSource="{cal:CalciteIconSource Icon=ZoomOutFixed, Scale=Small}" />
              </AppBarButton.Icon>
          </AppBarButton>
      </CommandBar.PrimaryCommands>
  </CommandBar>
```

## .NET MAUI

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
