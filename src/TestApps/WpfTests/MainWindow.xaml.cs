using Esri.Calcite.WPF;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace WpfTests
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LightToggle.Unchecked += LightToggle_Checked;
            LightToggle.Checked += LightToggle_Checked;
            StyleToggle.Checked += StyleToggle_Checked;
            StyleToggle.Unchecked += StyleToggle_Checked;
            LoadSampleContent();
        }

        private void LightToggle_Checked(object sender, RoutedEventArgs e)
        {
            var resource = Application.Current.Resources.MergedDictionaries.OfType<CalciteResources>().First();
            resource.Theme = LightToggle.IsChecked != true ? AppTheme.Light : AppTheme.Dark;
        }

        private void StyleToggle_Checked(object sender, RoutedEventArgs e)
        {
            var resource = Application.Current.Resources.MergedDictionaries.OfType<CalciteResources>().First();
            resource.IsCalciteImplicitStylingEnabled = StyleToggle.IsChecked == true ? true : false;
        }

        private void LoadSampleContent()
        {
            // Get path to bin
            var rootPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            rootPath = System.IO.Path.GetDirectoryName(rootPath);

            // Create a tab for each sample folder
            var categories = System.IO.Directory.EnumerateDirectories(System.IO.Path.Combine(rootPath!, "Samples"));
            foreach (var categoryPath in categories)
            {
                var categoryName = System.IO.Path.GetFileName(categoryPath);

                var samples = System.IO.Directory.EnumerateFiles(categoryPath);

                TabItem item = new TabItem() { Header = categoryName };
                ScrollViewer parentScroller = new ScrollViewer();
                StackPanel parentPanel = new StackPanel();

                item.Content = parentScroller;
                parentScroller.Content = parentPanel;

                foreach (var sample in samples)
                {
                    DemoWell sampleWell = new DemoWell() { SampleXamlPath = sample };
                    parentPanel.Children.Add(sampleWell);
                }
                ParentTabControl.Items.Add(item);
            }
        }
    }
}
