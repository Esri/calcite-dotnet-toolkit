
namespace Esri.Calcite.Maui
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    [System.ComponentModel.Browsable(false)]
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public static class CalciteResourceHelper
    {
        public static Color GetColor(BindableObject obj) => (Color)obj.GetValue(ColorProperty);

        public static void SetColor(BindableObject obj, Color value) => obj.SetValue(ColorProperty, value);

        public static readonly BindableProperty ColorProperty =
            BindableProperty.CreateAttached("Color", typeof(Color), typeof(CalciteResourceHelper), null);
        
        public static Color GetColor2(BindableObject obj) => (Color)obj.GetValue(Color2Property);

        public static void SetColor2(BindableObject obj, Color value) => obj.SetValue(Color2Property, value);

        public static readonly BindableProperty Color2Property =
            BindableProperty.CreateAttached("Color2", typeof(Color), typeof(CalciteResourceHelper), null);

        public static Color GetHoverColor(BindableObject obj)
        {
            return (Color)obj.GetValue(HoverColorProperty);
        }

        public static void SetHoverColor(BindableObject obj, Color value)
        {
            obj.SetValue(HoverColorProperty, value);
        }

        public static readonly BindableProperty HoverColorProperty =
            BindableProperty.CreateAttached("HoverColor", typeof(Color), typeof(CalciteResourceHelper), null);


        public static Color GetPressedColor(BindableObject obj)
        {
            return (Color)obj.GetValue(PressedColorProperty);
        }

        public static void SetPressedColor(BindableObject obj, Color value)
        {
            obj.SetValue(PressedColorProperty, value);
        }

        public static readonly BindableProperty PressedColorProperty =
            BindableProperty.CreateAttached("PressedColor", typeof(Color), typeof(CalciteResourceHelper), null);
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
