// COPYRIGHT © 2025 Esri
// All rights reserved under the copyright laws of the United States and applicable international laws, treaties, and conventions.
// This material is licensed for use under the Esri Master License Agreement (MLA), and is bound by the terms of that agreement.
// You may redistribute and use this code without modification, provided you adhere to the terms of the MLA and include this copyright notice.
//
// See use restrictions at http://www.esri.com/legal/pdfs/mla_e204_e300/english
//
// For additional information, contact: Environmental Systems Research Institute, Inc.
// Attn: Contracts and Legal Services Department 380 New York Street Redlands, California, USA 92373 USA. email: contracts@esri.com

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
                 fonts.AddFont("calcite-ui-icons-16.ttf", CalciteUIIconsSmallFontFamily)
                      .AddFont("calcite-ui-icons-24.ttf", CalciteUIIconsMediumFontFamily)
                      .AddFont("calcite-ui-icons-32.ttf", CalciteUIIconsLargeFontFamily));
            CustomMappings.ConfigureMappings();
            return builder;
        }
    }
}
