
In App.xaml below `XamlControlsResources` tag, add the CalciteResources to the XamlControlsResources merged dictionary:

```
<ResourceDictionary.MergedDictionaries>
    <XamlControlsResources xmlns="using:Microsoft.UI.Xaml.Controls" >
        <XamlControlsResources.MergedDictionaries>
            <CalciteResources xmlns="using:Esri.Calcite.WinUI" />
        </XamlControlsResources.MergedDictionaries>
    </XamlControlsResources>
</ResourceDictionary.MergedDictionaries>
```
