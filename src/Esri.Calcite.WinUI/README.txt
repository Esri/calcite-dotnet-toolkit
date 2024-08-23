## Usage

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

