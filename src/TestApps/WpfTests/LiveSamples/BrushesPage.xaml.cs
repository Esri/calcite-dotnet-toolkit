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
    public partial class BrushesPage : UserControl
    {
        Dictionary<string, object> icons = new System.Collections.Generic.Dictionary<string, object>();
        public BrushesPage()
        {
            InitializeComponent();
            var dic = Application.Current.Resources.MergedDictionaries.OfType<ResourceDictionary>().First();
            var brushes = dic.MergedDictionaries.OfType<ResourceDictionary>().Where(r => r.Source.OriginalString == @".\Colors\Brushes.xaml").First();           
            foreach (var key in brushes.Keys)
            {
                icons.Add((string)key, brushes[key]);
            }
            MyGridView.ItemsSource = icons;
        }

        private void filter_TextChanged(object sender, TextChangedEventArgs e)
        {
            MyGridView.ItemsSource = icons.Where(i => i.Key.Contains(filter.Text.Trim(), StringComparison.InvariantCultureIgnoreCase));
        }
    }

}
