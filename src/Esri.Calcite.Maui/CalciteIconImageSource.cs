// COPYRIGHT © 2025 Esri
// All rights reserved under the copyright laws of the United States and applicable international laws, treaties, and conventions.
// This material is licensed for use under the Esri Master License Agreement (MLA), and is bound by the terms of that agreement.
// You may redistribute and use this code without modification, provided you adhere to the terms of the MLA and include this copyright notice.
//
// See use restrictions at http://www.esri.com/legal/pdfs/mla_e204_e300/english
//
// For additional information, contact: Environmental Systems Research Institute, Inc.
// Attn: Contracts and Legal Services Department 380 New York Street Redlands, California, USA 92373 USA. email: contracts@esri.com

namespace Esri.Calcite.Maui
{
    /// <summary>
    /// A <see cref="FontImageSource" /> for displaying Calcite Icons in an <see cref="Image"/> control.
    /// </summary>
    public class CalciteIconImageSource : FontImageSource
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalciteIconImageSource"/> class.
        /// </summary>
        public CalciteIconImageSource()
        {
            base.FontFamily = AppHostBuilderExtensions.CalciteUIIconsSmallFontFamily;
        }

        private CalciteIconScale _scale = CalciteIconScale.Small;

        /// <summary>
        /// Gets or sets the icon scale
        /// </summary>
        public CalciteIconScale Scale
        {
            get { return _scale; }
            set
            {
                _scale = value;
                base.FontFamily = value switch
                {
                    CalciteIconScale.Small => AppHostBuilderExtensions.CalciteUIIconsSmallFontFamily,
                    CalciteIconScale.Medium => AppHostBuilderExtensions.CalciteUIIconsMediumFontFamily,
                    CalciteIconScale.Large => AppHostBuilderExtensions.CalciteUIIconsLargeFontFamily,
                        _ => AppHostBuilderExtensions.CalciteUIIconsSmallFontFamily
                };
            }
        }

        private CalciteIcon _icon;

        /// <summary>
        /// Gets or sets the icon to display
        /// </summary>
        public CalciteIcon Icon
        {
            get { return _icon; }
            set
            {
                _icon = value;
                char code = (char)(int)Icon;
                base.Glyph = code.ToString();
            }
        }
    }
}
