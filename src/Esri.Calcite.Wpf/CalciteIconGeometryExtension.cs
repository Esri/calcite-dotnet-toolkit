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
        public CalciteIcon Icon { get; set; }

        public CalciteIconScale Scale { get; set; } = CalciteIconScale.Small;

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
