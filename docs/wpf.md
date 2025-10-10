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

If you just want access to the resources and explicit styles, but not inherit any implicit styling, set `IsCalciteImplicitStylingEnabled="False"` on the `CalciteResources` entry.

## Using Brush resources

Brushes and colors can be referenced as dynamic resources.

```xml
<Border Background="{DynamicResource CalciteBrandBrush}">
  <TextBlock Text="Hello Calcite">
     <TextBlock.Foreground>
        <SolidColorBrush Color="{DynamicResource CalciteTextInverseColor} />
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

`CalciteIconGeometryExtension` : Convert an Icon to a Path Geometry. Example:

```xml
<Path Data="{calcite:CalciteIconGeometry Icon=ChevronLeft, Scale=Small}" Fill="Green" Width="32" Height="32" Stretch="Uniform" />
```

`CalciteIconImageExtension` : Convert an Icon to an Image Source. Example:
```xml
<Image Source="{calcite:CalciteIconImage Icon=AddLayer, Scale=Large, SymbolSize=32, Brush=Blue}" Width="32" Height="32" />
```

## Control styles

List of default control styles. These styles are applied implicitly unless implicit styles are disabled (`IsCalciteImplicitStylingEnabled = false`).

- Button: `CalciteButtonBaseStyle` 
- Calendar: `CalciteCalendarStyle`
- CheckBox: `CalciteCheckBoxStyle`
- ComboBox: `CalciteComboBoxStyle`
- DataGrid: `CalciteDataGridStyle`
- DatePicker: `CalciteDatePickerStyle`
- DocumentViewer: `CalciteDocumentViewerStyle`
- Expander: `CalciteExpanderStyle`
- GroupBox: `CalciteGroupBoxStyle`
- ListView: `CalciteListViewStyle`
- PasswordBox: `CalcitePasswordBoxStyle`
- ProgressBar: `CalciteProgressBarStyle`
- RadioButton: `CalciteRadioButtonStyle`
- Slider: `CalciteSliderStyle`
- StatusBar: `CalciteStatusBarStyle`
- StatusBarItem: `CalciteStatusBarItemStyle`
- TabControl: `CalciteTabControlStyle`
- TextBlock: `CalciteTextBlockStyle`
- TextBox: `CalciteTextBoxStyle`
- ToggleButton: `CalciteButtonBaseStyle`
- ToolBar: `CalciteToolBarStyle`
- ToolTip: `CalciteToolTipStyle`
- TreeView: `CalciteTreeViewStyle`

| Style | Target Type | Description | Example |
| --- | --- | --- | --- |
| `CalcitePrimaryButtonBaseStyle` | `ButtonBase` | Primary button style | ![image](https://github.com/user-attachments/assets/b77103d7-57f8-4ce8-8fea-36ecb4db3d44) |
| `CalcitePrimaryButtonStyle` | `Button` | Primary button style | ![image](https://github.com/user-attachments/assets/b77103d7-57f8-4ce8-8fea-36ecb4db3d44) |
| `CalciteSecondaryButtonBaseStyle` | `ButtonBase` | Secondary button style | ![image](https://github.com/user-attachments/assets/58ed445a-bb98-4a3b-8af5-c25ef0e913b8) |
| `CalciteSecondaryButtonStyle` | `Button` | Secondary button style | ![image](https://github.com/user-attachments/assets/58ed445a-bb98-4a3b-8af5-c25ef0e913b8) |
| `CalciteDangerButtonBaseStyle` | `ButtonBase` | Danger button style | ![image](https://github.com/user-attachments/assets/3c4b8471-14ec-46b0-ae0f-6aa537ed324e) |
| `CalciteDangerButtonStyle` | `Button` | Danger button style | ![image](https://github.com/user-attachments/assets/3c4b8471-14ec-46b0-ae0f-6aa537ed324e) |
| `CalciteDangerSecondaryButtonBaseStyle` | `ButtonBase` | Danger secondary button style | ![image](https://github.com/user-attachments/assets/e6387373-7d76-46b9-891c-51d618201155) |
| `CalciteDangerSecondaryButtonStyle` | `Button` | Danger secondary button style | ![image](https://github.com/user-attachments/assets/e6387373-7d76-46b9-891c-51d618201155) |
| `CalciteFormBorderStyle` | `Border` | Applies the default form padding to contained elements |    |
| `CalciteFormExpanderStyle` | `Expander` | GroupBox with extra padding for form elements  | ![image](https://github.com/user-attachments/assets/bbe7ce07-c88c-4317-bf1f-cff2146a72b6) |
| `CalciteBrandAlertGroupBoxStyle` | `GroupBox` | GroupBox with a brand color top line | ![image](https://github.com/user-attachments/assets/e16da37c-1973-4075-9204-d8592f604407) |
| `CalciteSuccessAlertGroupBoxStyle` | `GroupBox` | GroupBox with a brand color top line | ![image](https://github.com/user-attachments/assets/d88a7840-7a3d-4691-9412-ba494fc4726e) |
| `CalciteWarningAlertGroupBoxStyle` | `GroupBox` | GroupBox with a yellow top line for warnings | ![image](https://github.com/user-attachments/assets/8ed03e84-1154-4f12-ad49-220d328e3465) |
| `CalciteDangerAlertGroupBoxStyle` | `GroupBox` | GroupBox with a red top line for warnings | ![image](https://github.com/user-attachments/assets/fa14ea31-db14-4edc-be38-7cf0805261a4) |
| `CalcitePanelGroupBoxStyle` | `GroupBox` | A simple header/content group box style | ![image](https://github.com/user-attachments/assets/a9253f91-5f1e-43b1-8550-72de7ddc8da8) |
| `CalciteSidePanelFormGroupBoxStyle` | `GroupBox` | Same as CalcitePanelGroupBoxStyle but for side panels with no margin or drop shadows |   |
| `CalciteGroupBoxStyle` | `GroupBox` | The default group box style | ![image](https://github.com/user-attachments/assets/71e53a15-de77-4b82-89f6-6add504868e3) |
| `CalciteLabeledGroupBoxStyle` | `GroupBox` | Bold Header for simple grouping of sub-elements | ![image](https://github.com/user-attachments/assets/9aff9e57-ca78-4ed2-b016-56e6c1c9cfcd) |
| `CalciteActionPadToolBarStyle` | `Toolbar` | Same as the default toolbar but with a drop shadow to place on top of other view areas  | ![image](https://github.com/user-attachments/assets/da65ce4f-671d-46e7-9dcc-99a025c9b412) |
| `CalciteVerticalToolBarStyle` | `Toolbar` |   |   |

### Changing the brand colors
If you want to change the blue brand colors to match your own branding, redefine the following `Color` brushes after declaring the `CalciteResources` in `App.xaml`:

```xml
<Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <CalciteResources xmlns="http://schemas.esri.com/calcite/2024" Theme="Light" />
        </ResourceDictionary.MergedDictionaries>
        <!-- Overriding brand brushes: -->
        <Color x:Key="CalciteBrandColor">#7938B6</Color>
        <Color x:Key="CalciteBrandHoverColor">#652E98</Color>
        <Color x:Key="CalciteBrandPressColor">#51247A</Color>
        <Color x:Key="CalciteBrandUnderlineColor">#7938B6</Color>
    </ResourceDictionary>
</Application.Resources>
```

### Known Issues

When using dark mode, the background of the Window instances will not change due to [this WPF bug](https://github.com/dotnet/wpf/issues/10461) causing the default Window style to not get applied. To work around this issue, explicitly set the Window style on your Window:
```xml
<Window Style="{StaticResource CalciteWindowStyle}" >
```
