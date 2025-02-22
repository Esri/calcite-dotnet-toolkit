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
    /// Markup extension for converting calcite Icons into an Image Source
    /// </summary>
    [AcceptEmptyServiceProvider]
    [ContentProperty(nameof(Icon))]
    public class CalciteIconImageExtension : IMarkupExtension<ImageSource>
    {
        /// <summary>
        /// Gets or sets the icon to display
        /// </summary>
        public CalciteIcon Icon { get; set; }

        /// <summary>
        /// Gets or sets the color to use on the icon
        /// </summary>
        public Color Color { get; set; }

        /// <summary>
        /// Gets or sets the icon scaling
        /// </summary>
        public CalciteIconScale Scale { get; set; }

        /// <summary>
        /// Gets or sets the size applied to the symbol
        /// </summary>
        [System.ComponentModel.TypeConverter(typeof(FontSizeConverter))]
        public double Size { get; set; } = (double)FontImageSource.SizeProperty.DefaultValue;

        ImageSource IMarkupExtension<ImageSource>.ProvideValue(IServiceProvider serviceProvider)
        {
            return new CalciteIconImageSource
            {
                Icon = Icon,
                Color = Color,
                Size = Size,
                Scale = Scale
            };
        }

        object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider) => ((IMarkupExtension<ImageSource>)this).ProvideValue(serviceProvider);
    }
}
