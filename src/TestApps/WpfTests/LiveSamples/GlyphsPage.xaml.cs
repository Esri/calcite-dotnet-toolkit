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
        public string Glyph => ((char)(GlyphId)).ToString();
        public string GlyphHex => $"&#x{GlyphId.ToString("x2")};";
        public int GlyphId => (int)Icon;
        public string Name => Icon.ToString();
    }
}
