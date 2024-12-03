namespace Esri.Calcite.Maui
{
    public class CalciteIconImageSource : FontImageSource
    {
        public CalciteIconImageSource()
        {
            base.FontFamily = AppHostBuilderExtensions.CalciteUIIconsSmallFontFamily;
        }

        private CalciteIconScale _scale = CalciteIconScale.Small;

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
