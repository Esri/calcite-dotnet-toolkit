using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;

namespace Esri.Calcite.WPF
{
    /// <summary>
    /// Converts a <see cref="CalciteIcon"/> to a <see cref="string"/> Glyph that you can use with the Calcite UI Icons Font.
    /// </summary>
    [MarkupExtensionReturnType(typeof(string))]
    public class CalciteIconGlyphExtension : StaticResourceExtension
    {
        /// <summary>
        /// Gets or sets the Icon to convert to a <see cref="string"/> Glyph.
        /// </summary>
        public CalciteIcon? Icon { get; set; }

        private static SolidColorBrush DefaultBrush = new SolidColorBrush(Colors.Black);

        /// <inheritdoc />
        public override object? ProvideValue(IServiceProvider serviceProvider)
        {
            if (Icon is null)
                return null;
            char code = (char)(int)Icon;
            return code.ToString();
        }
    }
}
