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
    public partial class ColorsPage : UserControl
    {
        Dictionary<string, object> icons = new System.Collections.Generic.Dictionary<string, object>();
        public ColorsPage()
        {
            InitializeComponent();
            var dic = Application.Current.Resources.MergedDictionaries.OfType<CalciteResources>().First();
            var colors = dic.MergedDictionaries.OfType<ResourceDictionary>().Where(r => r.Source.OriginalString == @".\Colors\Colors.xaml").First();
           
            var light = dic.MergedDictionaries.OfType<ResourceDictionary>().Where(r => r.Source.OriginalString == @".\Colors\Colors.Light.xaml");
            var dark = dic.MergedDictionaries.OfType<ResourceDictionary>().Where(r => r.Source.OriginalString == @".\Colors\Colors.Dark.xaml");
            if(light != null && light.Any())
            {
                var lightDic = light.First();
                foreach (var key in lightDic.Keys)
                {
                    icons.Add((string)key, lightDic[key]);
                }
            }
            if (dark != null && dark.Any())
            {
                var darkDic = dark.First();
                foreach (var key in darkDic.Keys)
                {
                    icons.Add((string)key, darkDic[key]);
                }
            }
            foreach (var key in colors.Keys)
            {
                icons.Add((string)key, colors[key]);
            }
            MyGridView.ItemsSource = icons;
        }

        private void filter_TextChanged(object sender, TextChangedEventArgs e)
        {
            MyGridView.ItemsSource = icons.Where(i => i.Key.Contains(filter.Text.Trim(), StringComparison.InvariantCultureIgnoreCase));
        }
    }

}
