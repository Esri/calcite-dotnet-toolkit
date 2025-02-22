// COPYRIGHT © 2025 Esri
// All rights reserved under the copyright laws of the United States and applicable international laws, treaties, and conventions.
// This material is licensed for use under the Esri Master License Agreement (MLA), and is bound by the terms of that agreement.
// You may redistribute and use this code without modification, provided you adhere to the terms of the MLA and include this copyright notice.
//
// See use restrictions at http://www.esri.com/legal/pdfs/mla_e204_e300/english
//
// For additional information, contact: Environmental Systems Research Institute, Inc.
// Attn: Contracts and Legal Services Department 380 New York Street Redlands, California, USA 92373 USA. email: contracts@esri.com

using System.Windows;
using System.Windows.Controls;

namespace Esri.Calcite.WPF.Helpers
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    [System.ComponentModel.Browsable(false)]
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public static class GridHelpers
    {
        private static readonly DependencyProperty TextColumnStyleProperty =
            DependencyProperty.RegisterAttached("TextColumnStyle", typeof(Style), typeof(GridHelpers), new PropertyMetadata { PropertyChangedCallback = HandlePropertyChangeCallbck });

        private static readonly DependencyProperty CheckBoxColumnStyleProperty =
            DependencyProperty.RegisterAttached("CheckBoxColumnStyle", typeof(Style), typeof(GridHelpers), new PropertyMetadata { PropertyChangedCallback = HandlePropertyChangeCallbck });

        private static void HandlePropertyChangeCallbck(object obj, DependencyPropertyChangedEventArgs e)
        {
            var grid = (DataGrid)obj;
            if (e.OldValue == null && e.NewValue != null)
                grid.Columns.CollectionChanged += (obj2, e2) =>
                {
                    UpdateColumnStyles(grid);
                };
            UpdateColumnStyles(grid);
        }

        public static void SetTextColumnStyle(DependencyObject element, Style value) => element.SetValue(TextColumnStyleProperty, value);
        public static Style? GetTextColumnStyle(DependencyObject element) => element.GetValue(TextColumnStyleProperty) as Style;

        public static void SetCheckBoxColumnStyle(DependencyObject element, Style value) => element.SetValue(CheckBoxColumnStyleProperty, value);
        public static Style? GetCheckBoxColumnStyle(DependencyObject element) => element.GetValue(CheckBoxColumnStyleProperty) as Style;

        private static void UpdateColumnStyles(DataGrid grid)
        {
            foreach (var column in grid.Columns)
            {
                if (column is DataGridTextColumn tc)
                {
                    tc.ElementStyle = GetTextColumnStyle(grid);
                }
                else if (column is DataGridCheckBoxColumn cc)
                {
                    cc.ElementStyle = GetCheckBoxColumnStyle(grid);
                }
            }
        }
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
