// COPYRIGHT © 2025 Esri
// All rights reserved under the copyright laws of the United States and applicable international laws, treaties, and conventions.
// This material is licensed for use under the Esri Master License Agreement (MLA), and is bound by the terms of that agreement.
// You may redistribute and use this code without modification, provided you adhere to the terms of the MLA and include this copyright notice.
//
// See use restrictions at http://www.esri.com/legal/pdfs/mla_e204_e300/english
//
// For additional information, contact: Environmental Systems Research Institute, Inc.
// Attn: Contracts and Legal Services Department 380 New York Street Redlands, California, USA 92373 USA. email: contracts@esri.com

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace Esri.Calcite.WinUI
{
    /// <summary>
    /// Represents an icon that uses a glyph from the Calcite UI Symbols font as its content.
    /// </summary>
    public partial class SymbolIcon : IconSourceElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SymbolIcon"/> class.
        /// </summary>
        public SymbolIcon() : base()
        {
        }

        /// <summary>
        /// Gets or sets the symbol that is displayed by the icon source.
        /// </summary>
        public CalciteIcon Symbol
        {
            get => (CalciteIcon)GetValue(SymbolProperty);
            set => SetValue(SymbolProperty, value);
        }

        /// <summary>
        /// Identifies the <see cref="Symbol"/> dependency property.
        /// </summary>       
        public static readonly DependencyProperty SymbolProperty =
            DependencyProperty.Register(nameof(Symbol), typeof(CalciteIcon), typeof(SymbolIcon),
                new PropertyMetadata(default(CalciteIcon), (s, e) => ((SymbolIcon)s).OnSymbolPropertyChanged()));

        /// <summary>
        /// Gets or sets the scale/detail of the icon.
        /// </summary>
        public CalciteIconScale IconScale
        {
            get { return (CalciteIconScale)GetValue(IconScaleProperty); }
            set { SetValue(IconScaleProperty, value); }
        }

        /// <summary>
        /// Identifies the <see cref="IconScale"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty IconScaleProperty =
            DependencyProperty.Register(nameof(IconScale), typeof(CalciteIconScale), typeof(SymbolIcon), new PropertyMetadata(CalciteIconScale.Medium, (s, e) => ((SymbolIcon)s).OnSymbolPropertyChanged()));

        private void OnSymbolPropertyChanged()
        {
            var source = new CalciteFontIconSource()
            {
                Icon = Symbol,
                Scale = IconScale,
                FontSize = 16 + (int)IconScale * 8
            };
            this.IconSource = source;
        }
    }
}
