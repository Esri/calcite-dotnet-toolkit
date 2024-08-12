namespace Esri.Calcite.Maui
{

    [AcceptEmptyServiceProvider]
    [ContentProperty(nameof(Icon))]
    public class CalciteIconImageExtension : IMarkupExtension<ImageSource>
    {
        public CalciteIcon Icon { get; set; }

        public Color Color { get; set; }

        public CalciteIconScale Scale { get; set; }

        [System.ComponentModel.TypeConverter(typeof(FontSizeConverter))]
        public double Size { get; set; } = (double)FontImageSource.SizeProperty.DefaultValue;

        ImageSource IMarkupExtension<ImageSource>.ProvideValue(IServiceProvider serviceProvider)
        {
            return new CalciteIconImageSource
            {
                Icon = Icon,
                Color = Color,
                Size = Size,
                Scale = Scale
            };
        }

        object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider) => ((IMarkupExtension<ImageSource>)this).ProvideValue(serviceProvider);
    }
}
