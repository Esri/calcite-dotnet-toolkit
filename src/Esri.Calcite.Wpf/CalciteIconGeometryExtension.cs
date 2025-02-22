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
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Esri.Calcite.WPF
{
    /// <summary>
    /// Converts a <see cref="CalciteIcon"/> to a <see cref="Geometry"/> that you can use as <see cref="Path.Data"/> on an <see cref="Path"/>.
    /// </summary>
    [MarkupExtensionReturnType(typeof(Geometry))]
    public class CalciteIconGeometryExtension : StaticResourceExtension
    {
        /// <summary>
        /// Gets or sets the Icon to convert to a <see cref="Geometry"/>.
        /// </summary>
        public CalciteIcon Icon { get; set; }

        /// <summary>
        /// Gets or sets the icon scale / detail.
        /// </summary>
        public CalciteIconScale Scale { get; set; } = CalciteIconScale.Small;

        /// <inheritdoc />
        public override object? ProvideValue(IServiceProvider serviceProvider)
        {
            var font = Scale switch
            {
                CalciteIconScale.Small => CalciteResources.CalciteUISmallFont,
                CalciteIconScale.Large => CalciteResources.CalciteUILargeFont,
                CalciteIconScale.Medium => CalciteResources.CalciteUIMediumFont,
                _ => CalciteResources.CalciteUIMediumFont,
            };

            char code = (char)(int)Icon;
            FormattedText text = new FormattedText(code.ToString(),
                    CultureInfo.CurrentCulture,
                    FlowDirection.LeftToRight,
                    font.GetTypefaces().First(),
                    ((int)Scale + 1) * 16,
                    Brushes.Black, 96);
            Geometry geometry = text.BuildGeometry(new Point(5, 5));
            return geometry;
        }
    }
}
