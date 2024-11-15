using Microsoft.Maui.LifecycleEvents;
using Microsoft.Maui.Handlers;

[assembly: Microsoft.Maui.Controls.XmlnsPrefix("http://schemas.esri.com/calcite/2024", "calcite")]
[assembly: XmlnsDefinition("http://schemas.esri.com/calcite/2024", "Esri.Calcite.Maui")]

namespace Esri.Calcite.Maui
{
    /// <summary>
    /// Extensions used to configure ArcGIS Calcite resources
    /// </summary>
    public static class AppHostBuilderExtensions
    {
        internal const string CalciteUIIconsSmallFontFamily = "CalciteUIIconsSmallFontFamily";
        internal const string CalciteUIIconsMediumFontFamily = "CalciteUIIconsMediumFontFamily";
        internal const string CalciteUIIconsLargeFontFamily = "CalciteUIIconsLargeFontFamily";

        /// <summary>
        ///  Initializes the ArcGIS Calcite resources.
        /// </summary>
        /// <param name="builder">The Maui host builder.</param>
        /// <returns>The host builder</returns>
        public static MauiAppBuilder UseCalcite(this MauiAppBuilder builder)
        {
            builder = builder.ConfigureMauiHandlers(delegate (IMauiHandlersCollection a)
            {
            }).ConfigureFonts(fonts =>
                 fonts.AddEmbeddedResourceFont(typeof(AppHostBuilderExtensions).Assembly, "calcite-ui-icons-16.ttf", CalciteUIIconsSmallFontFamily)
                      .AddEmbeddedResourceFont(typeof(AppHostBuilderExtensions).Assembly, "calcite-ui-icons-24.ttf", CalciteUIIconsMediumFontFamily)
                      .AddEmbeddedResourceFont(typeof(AppHostBuilderExtensions).Assembly, "calcite-ui-icons-32.ttf", CalciteUIIconsLargeFontFamily));
#if WINDOWS
            builder = builder.ConfigureLifecycleEvents(events =>
            {
                events.AddWindows(w =>
                {
                    w.OnLaunching((app, e) =>
                    {
                        var xamlresources = app.Resources.MergedDictionaries.OfType<Microsoft.UI.Xaml.Controls.XamlControlsResources>().FirstOrDefault();
                        if(xamlresources is not null)
                        {
                            xamlresources.MergedDictionaries.Add(new Esri.Calcite.WinUI.CalciteResources());
                        }
                      
                    });
                });
            });
#endif

            /*RadioButtonHandler.Mapper.AppendToMapping("RadioButtonStyleOverride", (handler, view) =>
            {
#if WINDOWS
                // Temporary workaround for radiobutton on Windows
                // Note: This won't support resource overrides or theme changes
                var CalciteUIBrandLightColor = Windows.UI.Color.FromArgb(255, 0, 122, 194);
                var CalciteUIBrandHoverLightColor = Windows.UI.Color.FromArgb(255, 0, 97, 155);
                var CalciteUIBrandPressLightColor = Windows.UI.Color.FromArgb(255, 0, 72, 116);
                handler.PlatformView.Resources["RadioButtonOuterEllipseCheckedFillPressed"] = new Microsoft.UI.Xaml.Media.SolidColorBrush(CalciteUIBrandPressLightColor);
                handler.PlatformView.Resources["RadioButtonOuterEllipseCheckedStrokePressed"] = new Microsoft.UI.Xaml.Media.SolidColorBrush(CalciteUIBrandPressLightColor);
                handler.PlatformView.Resources["RadioButtonOuterEllipseCheckedFillPointerOver"] = new Microsoft.UI.Xaml.Media.SolidColorBrush(CalciteUIBrandHoverLightColor);
                handler.PlatformView.Resources["RadioButtonOuterEllipseCheckedFill"] = new Microsoft.UI.Xaml.Media.SolidColorBrush(CalciteUIBrandLightColor);
                handler.PlatformView.Resources["RadioButtonOuterEllipseCheckedStrokePointerOver"] = new Microsoft.UI.Xaml.Media.SolidColorBrush(CalciteUIBrandHoverLightColor);
                handler.PlatformView.Resources["RadioButtonOuterEllipseCheckedStroke"] = new Microsoft.UI.Xaml.Media.SolidColorBrush(CalciteUIBrandHoverLightColor);
#endif
            });*/
            return builder;
        }
    }
}
