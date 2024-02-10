using System;
using System.Collections.Generic;
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
    /// <summary>
    /// Interaction logic for WindowsPage.xaml
    /// </summary>
    public partial class DataGridPage : UserControl
    {
        public DataGridPage()
        {
            InitializeComponent();
            MyDataGrid.ItemsSource = TestDataItem.GetTestData();
        }

        class TestDataItem
        {
            public static IEnumerable<TestDataItem> GetTestData()
            {
                var list = new List<TestDataItem>();
                for (int x = 0; x < 100; x++)
                {
                    var item = new TestDataItem { ID = x, Title = $"Data Item {x}", TimeStamp = DateTime.Now.AddMonths(x), CurrencyValue = 100.0 * x, BoolValue = x % 2 == 0 };
                    list.Add(item);
                }
                return list;
            }
            public int ID { get; set; }
            public string Title { get; set; }
            public DateTime TimeStamp { get; set; }
            public double CurrencyValue { get; set; }
            public int CountValue { get; set; }
            public bool BoolValue { get; set; }
        }
    }
}
