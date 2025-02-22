// COPYRIGHT © 2025 Esri
// All rights reserved under the copyright laws of the United States and applicable international laws, treaties, and conventions.
// This material is licensed for use under the Esri Master License Agreement (MLA), and is bound by the terms of that agreement.
// You may redistribute and use this code without modification, provided you adhere to the terms of the MLA and include this copyright notice.
//
// See use restrictions at http://www.esri.com/legal/pdfs/mla_e204_e300/english
//
// For additional information, contact: Environmental Systems Research Institute, Inc.
// Attn: Contracts and Legal Services Department 380 New York Street Redlands, California, USA 92373 USA. email: contracts@esri.com

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


        public static Color GetColor3(BindableObject obj) => (Color)obj.GetValue(Color3Property);

        public static void SetColor3(BindableObject obj, Color value) => obj.SetValue(Color3Property, value);

        public static readonly BindableProperty Color3Property =
            BindableProperty.CreateAttached("Color3", typeof(Color), typeof(CalciteResourceHelper), null);

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
