using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace Esri.Calcite.WinUI
{
    public partial class CalciteFontIconSource : FontIconSource
    {
        public CalciteFontIconSource()
        {
            FontFamily = CalciteResources.CalciteUIFont;
        }

        public CalciteIcon Icon
        {
            get => (CalciteIcon)GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }

        /// <summary>
        /// Identifies the <see cref="Icon"/> dependency property.
        /// </summary>       
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register(nameof(Icon), typeof(CalciteIcon), typeof(CalciteFontIconSource),
                new PropertyMetadata(default(CalciteIcon), (s, e) => ((CalciteFontIconSource)s).OnIconPropertyChanged()));

        public CalciteIconScale Scale
        {
            get { return (CalciteIconScale)GetValue(ScaleProperty); }
            set { SetValue(ScaleProperty, value); }
        }

        public static readonly DependencyProperty ScaleProperty =
            DependencyProperty.Register(nameof(Scale), typeof(CalciteIconScale), typeof(CalciteFontIconSource), new PropertyMetadata(CalciteIconScale.Small, (s, e) => ((CalciteFontIconSource)s).OnIconPropertyChanged()));

        private void OnIconPropertyChanged()
        {
            char code = (char)((int)Icon + (int)Scale);
            base.Glyph = code.ToString();
        }
    }
}