using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Media;

namespace Esri.Calcite.WPF.Helpers
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    [System.ComponentModel.Browsable(false)]
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public static class Calcite
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Geometry GetIcon(DependencyObject obj) => (Geometry)obj.GetValue(IconProperty);
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static void SetIcon(DependencyObject obj, Geometry value) => obj.SetValue(IconProperty, value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.RegisterAttached("Icon", typeof(Geometry), typeof(Calcite), 
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));

        public static CalciteIcon? GetSymbol(DependencyObject obj) => (CalciteIcon)obj.GetValue(SymbolProperty);
        
        public static void SetSymbol(DependencyObject obj, CalciteIcon? value) => obj.SetValue(SymbolProperty, value);

        public static readonly DependencyProperty SymbolProperty =
            DependencyProperty.RegisterAttached("Symbol", typeof(CalciteIcon?), typeof(Calcite),
                new FrameworkPropertyMetadata((CalciteIcon)(0), FrameworkPropertyMetadataOptions.Inherits, OnSymbolPropertyChanged));

        private static void OnSymbolPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is FrameworkElement elm)
            {
                if (e.NewValue is null)
                    elm.ClearValue(IconProperty);
                else
                {
                    char code = (char)(int)(CalciteIcon)e.NewValue;
                    FormattedText text = new FormattedText(code.ToString(),
                        CultureInfo.CurrentCulture,
                        FlowDirection.LeftToRight,
                        CalciteResources.CalciteUISmallFont.GetTypefaces().First(),
                       16,
                       Brushes.Black, 96);
                    Geometry geometry = text.BuildGeometry(new Point(0, 0));
                    if (geometry.IsEmpty())
                        elm.ClearValue(IconProperty);
                    else
                        elm.SetValue(IconProperty, geometry);
                }
            }
        }
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
