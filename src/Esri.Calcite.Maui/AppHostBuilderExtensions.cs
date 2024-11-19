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

#if WINDOWS
            RadioButtonHandler.Mapper.AppendToMapping("CalciteRadioButtonStyleOverride", (handler, view) =>
            {
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
            });
            static Microsoft.UI.Xaml.Media.LinearGradientBrush GenerateBrush(Color c) {
                var brush = new Microsoft.UI.Xaml.Media.LinearGradientBrush()
                {
                    MappingMode = Microsoft.UI.Xaml.Media.BrushMappingMode.Absolute,
                    StartPoint = new Windows.Foundation.Point(0, 0),
                    EndPoint = new Windows.Foundation.Point(0, 2),
                    RelativeTransform = new Microsoft.UI.Xaml.Media.ScaleTransform() { ScaleY = -1, CenterY = .5 },
                };
                brush.GradientStops.Add(new Microsoft.UI.Xaml.Media.GradientStop() { Offset = 1, Color = Windows.UI.Color.FromArgb((byte)(c.Alpha * 255), (byte)(c.Red * 255), (byte)(c.Green * 255), (byte)(c.Blue * 255)) });
                brush.GradientStops.Add(new Microsoft.UI.Xaml.Media.GradientStop() { Offset = 1, Color = Microsoft.UI.Colors.Transparent });
                return brush;
            };
            EntryHandler.Mapper.AppendToMapping("CalciteEntryStyleOverride", (handler, view) =>
            {
                // Temporary workaround for entry bottom border styling limitation on Windows
                if (view is BindableObject bo)
                {
                    if (CalciteResourceHelper.GetColor(bo) is Color c)
                    {
                        handler.PlatformView.Resources["TextControlBorderBrushFocused"] = GenerateBrush(c);
                    }
                }
            });
            EditorHandler.Mapper.AppendToMapping("CalciteEditorStyleOverride", (handler, view) =>
            {
                // Temporary workaround for entry bottom border styling limitation on Windows
                if (view is BindableObject bo)
                {
                    if (CalciteResourceHelper.GetColor(bo) is Color c)
                    {
                        handler.PlatformView.Resources["TextControlBorderBrushFocused"] = GenerateBrush(c);
                    }
                }
            });
#endif
            return builder;
        }
    }
}
