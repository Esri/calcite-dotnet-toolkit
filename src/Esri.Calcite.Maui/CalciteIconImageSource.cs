namespace Esri.Calcite.Maui
{
    public class CalciteIconImageSource : FontImageSource
    {
        public CalciteIconImageSource()
        {
            base.FontFamily = "CalciteUIIconsFontFamily";
        }

        private CalciteIconScale _scale = CalciteIconScale.Small;

        public CalciteIconScale Scale
        {
            get { return _scale; }
            set
            {
                _scale = value;
                char code = (char)((int)Icon + (int)Scale);
                base.Glyph = code.ToString();
            }
        }

        private CalciteIcon _icon;
        
        public CalciteIcon Icon
        {
            get { return _icon; }
            set
            {
                _icon = value;
                char code = (char)((int)Icon + (int)Scale);
                base.Glyph = code.ToString();
            }
        }
    }
}
