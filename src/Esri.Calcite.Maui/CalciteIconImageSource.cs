namespace Esri.Calcite.Maui
{
    /// <summary>
    /// A <see cref="FontImageSource" /> for displaying Calcite Icons in an <see cref="Image"/> control.
    /// </summary>
    public class CalciteIconImageSource : FontImageSource
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalciteIconImageSource"/> class.
        /// </summary>
        public CalciteIconImageSource()
        {
            base.FontFamily = AppHostBuilderExtensions.CalciteUIIconsSmallFontFamily;
        }

        private CalciteIconScale _scale = CalciteIconScale.Small;

        /// <summary>
        /// Gets or sets the icon scale
        /// </summary>
        public CalciteIconScale Scale
        {
            get { return _scale; }
            set
            {
                _scale = value;
                base.FontFamily = value switch
                {
                    CalciteIconScale.Small => AppHostBuilderExtensions.CalciteUIIconsSmallFontFamily,
                    CalciteIconScale.Medium => AppHostBuilderExtensions.CalciteUIIconsMediumFontFamily,
                    CalciteIconScale.Large => AppHostBuilderExtensions.CalciteUIIconsLargeFontFamily,
                        _ => AppHostBuilderExtensions.CalciteUIIconsSmallFontFamily
                };
            }
        }

        private CalciteIcon _icon;

        /// <summary>
        /// Gets or sets the icon to display
        /// </summary>
        public CalciteIcon Icon
        {
            get { return _icon; }
            set
            {
                _icon = value;
                char code = (char)(int)Icon;
                base.Glyph = code.ToString();
            }
        }
    }
}
