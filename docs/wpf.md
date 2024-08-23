# WPF

## Usage<a name="usage" />

Add the CalciteResources ResourceDictionary to your App.xaml Merged Directionary resources to get access
to default styles and resources. Dark/Light mode is automatically handled and adjust to system or app settings.

```xml
    <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <CalciteResources xmlns="http://schemas.esri.com/calcite/2024" Theme="Light" />
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Application.Resources>
```

You can set the Theme to `Light`, `Dark` or `Default`, where Default will automatically follow the system styling.

If you just want access to the resources and explicit styles, but not inherit any implicit styling, set `IsCalciteImplicitStylingEnabled="True"` on the `CalciteResources` entry.

## Using Brush resources

Brushes and colors can be referenced as dynamic resources.

```xml
<Border Background="{DynamicResource CalciteUIBrandBrush}">
  <TextBlock Text="Hello Calcite">
     <TextBlock.Foreground>
        <SolidColorBrush Color="{DynamicResource CalciteUITextInverseColor} />
     </TextBlock.Foreground>
  </TextBlock>
</Border>
```

For a full list of calcite brushes and colors see [Color and Brush resources](brushes.md).

## Symbol Font
`CalciteUIIconsFontFamily` FontFamily is a font with a set of symbols generated from the [Calcite UI Icons repo](https://github.com/Esri/calcite-ui-icons).
This font can be referred to with the resource key `CalciteUIIconsFontFamily`.

Example:
```xml
<TextBlock Text="{StaticResource CalciteUIIcons_Glyph_Map_24}" 
           FontFamily="{StaticResource CalciteUIIconsFontFamily}" />
```

For a full list of Glyph Resource IDs refer to the sample apps and the [Calcite-UI-Icons](https://github.com/Esri/calcite-ui-icons) repo.

## Markup Extensions

`CalciteIconGeometryExtension` : Convert an Icon to a Path Geometry. Example:

```xml
<Path Data="{calcite:CalciteIconGeometry Icon=ChevronLeft, Scale=Small}" Fill="Green" Width="32" Height="32" Stretch="Uniform" />
```

`CalciteIconImageExtension` : Convert an Icon to an Image Source. Example:
```xml
<Image Source="{calcite:CalciteIconImage Icon=AddLayer, Scale=Large, SymbolSize=32, Brush=Blue}" Width="32" Height="32" />
```

## Control styles

- Buttons: `CalcitePrimaryButtonStyle`, `CalciteSecondaryButtonStyle`, `CalciteDangerButtonStyle`, `CalciteDangerSecondaryButtonStyle`
- TreeView: `CalciteTreeViewStyle`
- TextBox: `CalciteTextBoxStyle`
- PasswordBox: `CalcitePasswordBoxStyle`
- TabControl: `CalciteTabStyle`
- Slider: `CalciteSliderStyle`
- RadioButton: `CalciteRadioButtonStyle`
- ProgressBar: `CalciteProgressBarStyle`
- ListView: `CalciteListViewStyle`
- ComboBox: `CalciteComboBoxStyle`
- CheckBox: `CalciteCheckboxStyle`
- Calendar: `CalciteCalendarStyle`
- Button: `CalcitePrimaryButtonBaseStyle`
- ToggleButton: `CalcitePrimaryButtonBaseStyle`
- TextBlock: `TextBlockStyle`
- DatePicker: `CalciteDatePicker`
- StatusBar: `CalciteStatusBar`
- Expander: `CalciteExpander`
- ToolTip: `CalciteToolTip`
- DataGrid: `CalciteDataGrid`
- ToolBar: `CalciteToolBar`
- DocumentViewer: `CalciteDocumentViewer`
- StatusBarItem: `CalciteStatusBarItem`