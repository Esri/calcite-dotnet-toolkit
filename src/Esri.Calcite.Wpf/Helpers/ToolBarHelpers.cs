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

namespace Esri.Calcite.WPF.Helpers
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    [System.ComponentModel.Browsable(false)]
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public static class ToolBarHelpers
    {
        public static bool GetIsExpanded(DependencyObject obj) => (bool)obj.GetValue(IsExpandedProperty);
        public static void SetIsExpanded(DependencyObject obj, bool value) => obj.SetValue(IsExpandedProperty, value);

        public static readonly DependencyProperty IsExpandedProperty =
            DependencyProperty.RegisterAttached("IsExpanded", typeof(bool), typeof(ToolBarHelpers), new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.OverridesInheritanceBehavior));

        public static bool GetShowExpander(DependencyObject obj) => (bool)obj.GetValue(ShowExpanderProperty);
        public static void SetShowExpander(DependencyObject obj, bool value) => obj.SetValue(ShowExpanderProperty, value);

        public static readonly DependencyProperty ShowExpanderProperty =
            DependencyProperty.RegisterAttached("ShowExpander", typeof(bool), typeof(ToolBarHelpers), new FrameworkPropertyMetadata(false));
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
