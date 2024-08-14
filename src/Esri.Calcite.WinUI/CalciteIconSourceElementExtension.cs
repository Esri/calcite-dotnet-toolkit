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
    public class CalciteIconSourceElementExtension : MarkupExtension
    {
        public CalciteIcon Icon { get; set; }

        public Brush? Foreground { get; set; }

        public CalciteIconScale Scale { get; set; } = CalciteIconScale.Medium;

        public double SymbolSize { get; set; } = 24;

        protected override object ProvideValue() =>
            new SymbolIcon() {  Symbol = Icon, IconScale = Scale, Width = SymbolSize, Height = SymbolSize, Foreground = Foreground };
    }
}
