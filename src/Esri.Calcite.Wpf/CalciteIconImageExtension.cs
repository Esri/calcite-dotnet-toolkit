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
        public CalciteIcon? Icon { get; set; }

        public Brush? Brush { get; set; }

        private static SolidColorBrush DefaultBrush = new SolidColorBrush(Colors.Black);

        public CalciteIconScale Scale { get; set; } = CalciteIconScale.Small;
        public double SymbolSize { get; set; } = 16;

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
