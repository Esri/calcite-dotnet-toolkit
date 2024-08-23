## Usage

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
