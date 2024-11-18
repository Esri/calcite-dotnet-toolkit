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
    public partial class CalciteIconSourceExtension : MarkupExtension
    {
        /// <summary>
        /// Gets or sets the Icon to convert to a <see cref="CalciteFontIconSource"/>.
        /// </summary>
        public CalciteIcon Icon { get; set; }

        /// <summary>
        /// Gets or sets the brush to use for the icon.
        /// </summary>
        public Brush? Foreground { get; set; }

        /// <summary>
        /// Gets or sets the icon scale / detail.
        /// </summary>
        public CalciteIconScale Scale { get; set; } = CalciteIconScale.Medium;

        /// <summary>
        /// Gets or sets the size of the symbol.
        /// </summary>
        public double SymbolSize { get; set; } = 24;

        /// <inheritdoc />
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
