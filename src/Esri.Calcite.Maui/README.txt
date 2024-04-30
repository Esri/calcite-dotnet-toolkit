
In App.xaml inside `MergedDictionaries` tag, add:

```
    <CalciteResources xmlns="clr-namespace:Esri.Calcite.Maui;assembly=Esri.Calcite.Maui"/>
```

Next register calcite:

using Esri.Calcite.Maui;
//...

builder.UseCalcite();