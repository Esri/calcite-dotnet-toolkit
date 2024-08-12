using Esri.Calcite.WinUI;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Markup;
using Microsoft.UI.Xaml.Media;
using System;

namespace Esri.Calcite.WinUI
{
    /// <summary>
    /// Converts a <see cref="CalciteIcon"/> to a <see cref="IconSourceElement"/> that you can use on 
    /// for instance an <see cref="AppBarButton"/>'s <see cref="AppBarButton.Icon"/> property.
    /// </summary>
    [MarkupExtensionReturnType(ReturnType = typeof(IconSourceElement))]
    public class CalciteIconSourceElementExtension : MarkupExtension
    {
        public CalciteIcon Icon { get; set; }

        public Brush? Foreground { get; set; }

        public CalciteIconScale Scale { get; set; } = CalciteIconScale.Small;

        public double SymbolSize { get; set; } = 16;

        protected override object ProvideValue()
        {
            var source = new CalciteFontIconSource()
            {
                Icon = Icon,
                Scale = Scale,
            };
            if (Foreground != null)
                source.Foreground = Foreground;
            var elm = new IconSourceElement()
            {
                Width = SymbolSize,
                Height = SymbolSize,
                IconSource = source
            };
            return elm;
        }
    }
}
