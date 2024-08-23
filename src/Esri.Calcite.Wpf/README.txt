## Usage

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
