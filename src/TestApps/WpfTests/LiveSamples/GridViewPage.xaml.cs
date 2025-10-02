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
using System.Collections.Generic;
using System.Windows.Controls;

namespace WpfTests.Samples
{
    /// <summary>
    /// Interaction logic for GridView.xaml
    /// </summary>
    public partial class GridViewPage : UserControl
    {
        public GridViewPage()
        {
            InitializeComponent();
            MyGridView.ItemsSource = TestDataItem.GetTestData();
        }

        private class TestDataItem
        {
            public static IEnumerable<TestDataItem> GetTestData()
            {
                var list = new List<TestDataItem>();
                for (int x = 0; x < 100; x++)
                {
                    var item = new TestDataItem { ID = x, Title = $"Data Item {x}", TimeStamp = DateTime.Now.AddMonths(x), CurrencyValue = 100.0 * x };
                    list.Add(item);
                }
                return list;
            }

            public int ID { get; set; }
            public string? Title { get; set; }
            public DateTime TimeStamp { get; set; }
            public double CurrencyValue { get; set; }
            public int CountValue { get; set; }
        }
    }
}
