using Esri.Calcite.WinUI;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Markup;
using Microsoft.UI.Xaml.Media;
using System;

namespace Esri.Calcite.WinUI
{
    /// <summary>
    /// Markup extension that converts a <see cref="CalciteIcon"/> to a <see cref="CalciteFontIconSource"/> that you can use as an <see cref="IconSource"/> on an <see cref="IconSourceElement"/>.
    /// </summary>
    [MarkupExtensionReturnType(ReturnType = typeof(CalciteFontIconSource))]
    public class CalciteIconSourceExtension : MarkupExtension
    {
        public CalciteIcon Icon { get; set; }

        public Brush? Foreground { get; set; }

        public CalciteIconScale Scale { get; set; } = CalciteIconScale.Medium;

        public double SymbolSize { get; set; } = 24;

        protected override object? ProvideValue()
        {
            var source = new CalciteFontIconSource() {
                Icon = Icon,
                Scale = Scale
            };
            if (Foreground != null)
                source.Foreground = Foreground;
            return source;
        }
    }
}
