using Esri.Calcite.WinUI;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Markup;
using Microsoft.UI.Xaml.Media;
using System;

namespace Esri.Calcite.WinUI
{
    /// <summary>
    /// Markup extension that converts a <see cref="CalciteIcon"/> to an <see cref="IconSourceElement"/> that you can use on 
    /// for instance an <see cref="AppBarButton"/>'s <see cref="AppBarButton.Icon"/> property.
    /// </summary>
    [MarkupExtensionReturnType(ReturnType = typeof(IconSourceElement))]
    public partial class CalciteIconSourceElementExtension : MarkupExtension
    {
        /// <summary>
        /// Gets or sets the Icon to convert to an <see cref="IconSourceElement"/>.
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
        protected override object ProvideValue()
        {
            var icon = new SymbolIcon() { Symbol = Icon, IconScale = Scale, Width = SymbolSize, Height = SymbolSize};
            if (Foreground != null)
                icon.Foreground = Foreground;
            return icon;
        }
    }
}
