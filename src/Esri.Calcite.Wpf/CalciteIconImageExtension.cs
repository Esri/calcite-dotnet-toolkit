// COPYRIGHT © 2025 Esri
// All rights reserved under the copyright laws of the United States and applicable international laws, treaties, and conventions.
// This material is licensed for use under the Esri Master License Agreement (MLA), and is bound by the terms of that agreement.
// You may redistribute and use this code without modification, provided you adhere to the terms of the MLA and include this copyright notice.
//
// See use restrictions at http://www.esri.com/legal/pdfs/mla_e204_e300/english
//
// For additional information, contact: Environmental Systems Research Institute, Inc.
// Attn: Contracts and Legal Services Department 380 New York Street Redlands, California, USA 92373 USA. email: contracts@esri.com

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;

namespace Esri.Calcite.WPF
{
    /// <summary>
    /// Converts a <see cref="CalciteIcon"/> to a <see cref="DrawingImage"/> that you can use as an <see cref="ImageSource"/> on an <see cref="Image"/>.
    /// </summary>
    [MarkupExtensionReturnType(typeof(DrawingImage))]
    public class CalciteIconImageExtension : StaticResourceExtension
    {
        /// <summary>
        /// Gets or sets the Icon to convert to a <see cref="DrawingImage"/>.
        /// </summary>
        public CalciteIcon? Icon { get; set; }

        /// <summary>
        /// Gets or sets the brush to use for the icon.
        /// </summary>
        public Brush? Brush { get; set; }

        private static SolidColorBrush DefaultBrush = new SolidColorBrush(Colors.Black);

        /// <summary>
        /// Gets or sets the icon scale / detail.
        /// </summary>
        public CalciteIconScale Scale { get; set; } = CalciteIconScale.Small;

        /// <summary>
        /// Gets or sets the size of the symbol.
        /// </summary>
        public double SymbolSize { get; set; } = 16;

        /// <inheritdoc />
        public override object? ProvideValue(IServiceProvider serviceProvider)
        {
            if (Icon is null)
                return null;
            var font = Scale switch
            {
                CalciteIconScale.Small => CalciteResources.CalciteUISmallFont,
                CalciteIconScale.Large => CalciteResources.CalciteUILargeFont,
                CalciteIconScale.Medium => CalciteResources.CalciteUIMediumFont,
                _ => CalciteResources.CalciteUIMediumFont,
            };
            char code = (char)(int)Icon;
            var tb = new TextBlock
            {
                Text = code.ToString(),
                FontFamily = font,
                Foreground = Brush ?? DefaultBrush
            };
            var geometryDrawing = new GeometryDrawing
            {
                Brush = new VisualBrush
                {
                    Visual = tb,
                    Stretch = Stretch.Uniform
                },
                Geometry = new RectangleGeometry(new Rect(0, 0, SymbolSize, SymbolSize))
            };

            return new DrawingImage(geometryDrawing);
        }
    }
}
