namespace Esri.Calcite.Maui
{
    /// <summary>
    /// Markup extension for converting calcite Icons into an Image Source
    /// </summary>
    [AcceptEmptyServiceProvider]
    [ContentProperty(nameof(Icon))]
    public class CalciteIconImageExtension : IMarkupExtension<ImageSource>
    {
        /// <summary>
        /// Gets or sets the icon to display
        /// </summary>
        public CalciteIcon Icon { get; set; }

        /// <summary>
        /// Gets or sets the color to use on the icon
        /// </summary>
        public Color Color { get; set; }

        /// <summary>
        /// Gets or sets the icon scaling
        /// </summary>
        public CalciteIconScale Scale { get; set; }

        /// <summary>
        /// Gets or sets the size applied to the symbol
        /// </summary>
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
