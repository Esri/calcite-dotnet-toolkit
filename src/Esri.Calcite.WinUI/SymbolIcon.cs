using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace Esri.Calcite.WinUI
{

    /// <summary>
    /// Represents an icon that uses a glyph from the Calcite UI Symbols font as its content.
    /// </summary>
    public partial class SymbolIcon : IconSourceElement
    {
        public SymbolIcon() : base()
        {
        }

        public CalciteIcon Symbol
        {
            get => (CalciteIcon)GetValue(SymbolProperty);
            set => SetValue(SymbolProperty, value);
        }

        /// <summary>
        /// Identifies the <see cref="Symbol"/> dependency property.
        /// </summary>       
        public static readonly DependencyProperty SymbolProperty =
            DependencyProperty.Register(nameof(Symbol), typeof(CalciteIcon), typeof(SymbolIcon),
                new PropertyMetadata(default(CalciteIcon), (s, e) => ((SymbolIcon)s).OnSymbolPropertyChanged()));

        public CalciteIconScale IconScale
        {
            get { return (CalciteIconScale)GetValue(IconScaleProperty); }
            set { SetValue(IconScaleProperty, value); }
        }

        public static readonly DependencyProperty IconScaleProperty =
            DependencyProperty.Register(nameof(IconScale), typeof(CalciteIconScale), typeof(SymbolIcon), new PropertyMetadata(CalciteIconScale.Medium, (s, e) => ((SymbolIcon)s).OnSymbolPropertyChanged()));

        private void OnSymbolPropertyChanged()
        {
            var source = new CalciteFontIconSource()
            {
                Icon = Symbol,
                Scale = IconScale,
                FontSize = 16 + (int)IconScale * 8
            };
            this.IconSource = source;
        }
    }
}
