using Esri.Calcite.WPF;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfTests.Samples
{
    public partial class GlyphsPage : UserControl
    {
        List<IconEntry> icons = new List<IconEntry>();
        public GlyphsPage()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            icons = new List<IconEntry>();
            foreach (var i in Enum.GetValues(typeof(CalciteIcon)))
            {
                icons.Add(new IconEntry() { Icon = (CalciteIcon)i });
            }
            MyGridView.ItemsSource = icons;
        }

        private void filter_TextChanged(object sender, TextChangedEventArgs e)
        {
            MyGridView.ItemsSource = icons.Where(i => i.Name.Contains(filter.Text.Trim(), StringComparison.InvariantCultureIgnoreCase));
        }
    }

    public class IconEntry
    {
        public CalciteIcon Icon { get; set; }
        public string Glyph16 => ((char)(GlyphId16)).ToString();
        public string GlyphHex16 => $"&#x{GlyphId16.ToString("x2")};";
        public int GlyphId16 => (int)Icon;
        public string Glyph24 => ((char)(GlyphId24)).ToString();
        public int GlyphId24 => (int)Icon + 1;
        public string GlyphHex24 => $"&#x{GlyphId24.ToString("x2")};";
        public string Glyph32 => ((char)(GlyphId32)).ToString();
        public int GlyphId32 => (int)Icon + 2;
        public string GlyphHex32 => $"&#x{GlyphId32.ToString("x2")};";
        public string Name => Icon.ToString();
    }
}
