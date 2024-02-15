namespace Esri.Calcite.Maui
{
    /// <summary>
    /// Extensions used to configure ArcGIS Calcite resources
    /// </summary>
    public static class AppHostBuilderExtensions
    { /// <summary>
      ///  Initializes the ArcGIS Calcite resources.
      /// </summary>
      /// <param name="builder">The Maui host builder.</param>
      /// <returns>The host builder</returns>
        public static MauiAppBuilder UseCalcite(this MauiAppBuilder builder)
        {
            builder.ConfigureMauiHandlers(delegate (IMauiHandlersCollection a)
            {
            }).ConfigureFonts(fonts =>
                 fonts.AddEmbeddedResourceFont(typeof(AppHostBuilderExtensions).Assembly, "calcite-ui-icons.ttf", "calcite-ui-icons")
                      //.AddFont("AvenirNextW1G-Demi.otf", "AvenirNextW1G-Demi")
                      //.AddFont("AvenirNextW1G-Light.otf", "AvenirNextW1G-Light")
                      //.AddFont("AvenirNextW1G-Medium.otf", "AvenirNextW1G-Medium")
                      //.AddFont("AvenirNextW1G-Regular.otf", "AvenirNextW1G-Regular")
                 ) ;//.ConfigureImageSources(;
            
            return builder;
        }
    }
}
