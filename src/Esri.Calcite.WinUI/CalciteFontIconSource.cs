// COPYRIGHT © 2025 Esri
// All rights reserved under the copyright laws of the United States and applicable international laws, treaties, and conventions.
// This material is licensed for use under the Esri Master License Agreement (MLA), and is bound by the terms of that agreement.
// You may redistribute and use this code without modification, provided you adhere to the terms of the MLA and include this copyright notice.
//
// See use restrictions at http://www.esri.com/legal/pdfs/mla_e204_e300/english
//
// For additional information, contact: Environmental Systems Research Institute, Inc.
// Attn: Contracts and Legal Services Department 380 New York Street Redlands, California, USA 92373 USA. email: contracts@esri.com

using System;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace Esri.Calcite.WinUI
{
    /// <summary>
    /// A <see cref="FontIconSource"/> that uses the Calcite UI Icons font.
    /// </summary>
    public partial class CalciteFontIconSource : FontIconSource
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalciteFontIconSource"/> class.
        /// </summary>
        public CalciteFontIconSource()
        {
            FontFamily = CalciteResources.CalciteUIFont_Small;
        }

        /// <summary>
        /// Gets or sets the icon to display.
        /// </summary>
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

        private void OnIconPropertyChanged()
        {
            char code = (char)(int)Icon;
            base.Glyph = code.ToString();
        }

        /// <summary>
        /// Gets or sets the scale/detail of the icon.
        /// </summary>
        public CalciteIconScale Scale
        {
            get { return (CalciteIconScale)GetValue(ScaleProperty); }
            set { SetValue(ScaleProperty, value); }
        }

        /// <summary>
        /// Identifies the <see cref="Scale"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty ScaleProperty =
            DependencyProperty.Register(nameof(Scale), typeof(CalciteIconScale), typeof(CalciteFontIconSource), new PropertyMetadata(CalciteIconScale.Small, (s, e) => ((CalciteFontIconSource)s).OnScalePropertyChanged()));

        private void OnScalePropertyChanged()
        {
            base.FontFamily = Scale switch
            {
                CalciteIconScale.Large => CalciteResources.CalciteUIFont_Large,
                CalciteIconScale.Medium => CalciteResources.CalciteUIFont_Medium,
                CalciteIconScale.Small => CalciteResources.CalciteUIFont_Small,
                _ => CalciteResources.CalciteUIFont_Small,
            };
        }
    }
}