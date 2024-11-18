using Microsoft.Maui.LifecycleEvents;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;

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

            RadioButtonHandler.Mapper.AppendToMapping("RadioButtonStyleOverride", (handler, view) =>
            {
#if WINDOWS
                // Temporary workaround for radiobutton styling limitation on Windows
                if (view is BindableObject bo)
                {
                    if (CalciteResourceHelper.GetColor(bo) is Color c)
                    {
                        handler.PlatformView.Resources["RadioButtonOuterEllipseCheckedFill"] =
                        handler.PlatformView.Resources["RadioButtonOuterEllipseCheckedStroke"] = c.ToPlatform();
                    }
                    if (CalciteResourceHelper.GetHoverColor(bo) is Color pressedColor)
                    {
                        handler.PlatformView.Resources["RadioButtonOuterEllipseCheckedFillPressed"] =
                        handler.PlatformView.Resources["RadioButtonOuterEllipseCheckedStrokePressed"] = pressedColor.ToPlatform();
                    }
                    if (CalciteResourceHelper.GetPressedColor(bo) is Color hoverColor)
                    {
                        handler.PlatformView.Resources["RadioButtonOuterEllipseCheckedFillPointerOver"] =
                        handler.PlatformView.Resources["RadioButtonOuterEllipseCheckedStrokePointerOver"] = hoverColor.ToPlatform();
                    }
                }
#endif
            });
            return builder;
        }
    }
}
