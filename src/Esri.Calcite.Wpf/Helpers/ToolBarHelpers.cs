﻿using System.Windows;

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
