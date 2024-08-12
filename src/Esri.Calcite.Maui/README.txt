
In App.xaml inside `MergedDictionaries` tag, add:

```
    <CalciteResources xmlns="http://schemas.esri.com/calcite/2024"/>
```

Next register Calcite in MauiProgram.cs:

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
