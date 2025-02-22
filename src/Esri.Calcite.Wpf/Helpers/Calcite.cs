// COPYRIGHT © 2025 Esri
// All rights reserved under the copyright laws of the United States and applicable international laws, treaties, and conventions.
// This material is licensed for use under the Esri Master License Agreement (MLA), and is bound by the terms of that agreement.
// You may redistribute and use this code without modification, provided you adhere to the terms of the MLA and include this copyright notice.
//
// See use restrictions at http://www.esri.com/legal/pdfs/mla_e204_e300/english
//
// For additional information, contact: Environmental Systems Research Institute, Inc.
// Attn: Contracts and Legal Services Department 380 New York Street Redlands, California, USA 92373 USA. email: contracts@esri.com

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
