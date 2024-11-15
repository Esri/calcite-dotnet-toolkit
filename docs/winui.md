# WinUI 3

## Usage<a name="usage" />

Add the CalciteResources ResourceDictionary to your App.xaml Merged Directionary resources inside the default `XamlControlsResources` to get access
to default styles and resources. Dark/Light mode is automatically handled and adjust to system or app settings.

```xml
    <ResourceDictionary.MergedDictionaries>
        <XamlControlsResources xmlns="using:Microsoft.UI.Xaml.Controls" >
            <XamlControlsResources.MergedDictionaries>
                <CalciteResources xmlns="using:Esri.Calcite.WinUI" />
            </XamlControlsResources.MergedDictionaries>
        </XamlControlsResources>
    </ResourceDictionary.MergedDictionaries>
```

If you don't want the default implicit Calcite styles, place the `CalciteResources` entry in App.xaml outside and before the `XamlControlsResources` entry.

## Using Brush resources

Brushes and colors can be referenced as static resources.

```xml
<Border Background="{ThemeResource CalciteUIBrandBrush}">
  <TextBlock Text="Hello Calcite">
     <TextBlock.Foreground>
        <SolidColorBrush Color="{ThemeResource CalciteUITextInverseColor} />
     </TextBlock.Foreground>
  </TextBlock>
</Border>
```

For a full list of calcite brushes and colors see [Color and Brush resources](brushes.md).

## Symbol Font
`CalciteUIIconsSmallFontFamily`, `CalciteUIIconsMediumFontFamily` and `CalciteUIIconsLargeFontFamily` FontFamilies are fonts with a set of symbols generated from the [Calcite UI Icons repo](https://github.com/Esri/calcite-ui-icons).
This font FontFamily can directly be referred to by its name `CalciteUIIcons[Small/Medium/Large]FontFamily`.

Example:
```xml
<TextBlock Text="{StaticResource CalciteUIIcons_Glyph_Map}" 
           FontFamily="{StaticResource CalciteUIIconsMediumFontFamily}" />
```

For a full list of Glyph Resource IDs refer to the sample apps and the [Calcite-UI-Icons](https://github.com/Esri/calcite-ui-icons) repo.


## Markup Extensions

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

## Control styles

- Buttons: `CalcitePrimaryButtonStyle`, `CalciteSecondaryButtonStyle`, `CalciteDangerButtonStyle`, `CalciteDangerSecondaryButtonStyle`
- TextBox: `CalciteTextBoxStyle`