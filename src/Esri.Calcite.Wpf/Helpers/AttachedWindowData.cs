using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Esri.Calcite.WPF.Helpers
{
    public static class AttachedWindowData
    {
        public static FrameworkElement GetWindowTitleBarCenteredInset (DependencyObject obj) => obj.GetValue(WindowTitleBarCenteredInsetProperty) as FrameworkElement;
        public static void SetWindowTitleBarCenteredInset (DependencyObject obj, FrameworkElement value) => obj.SetValue(WindowTitleBarCenteredInsetProperty, value);
        public static readonly DependencyProperty WindowTitleBarCenteredInsetProperty =
            DependencyProperty.RegisterAttached("WindowTitleBarCenteredInset", typeof(FrameworkElement), typeof(AttachedWindowData), new FrameworkPropertyMetadata(null));
        public static bool GetShowCancel(DependencyObject obj) => (bool)obj.GetValue(ShowCancelProperty);
        public static void SetShowCancel(DependencyObject obj, bool value) => obj.SetValue(ShowCancelProperty, value);

        public static readonly DependencyProperty ShowCancelProperty =
            DependencyProperty.RegisterAttached("ShowCancel", typeof(bool), typeof(AttachedWindowData), new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.OverridesInheritanceBehavior));

        public static bool GetShowOk(DependencyObject obj) => (bool)obj.GetValue(ShowOkProperty);
        public static void SetShowOk(DependencyObject obj, bool value) => obj.SetValue(ShowOkProperty, value);

        public static readonly DependencyProperty ShowOkProperty =
            DependencyProperty.RegisterAttached("ShowOk", typeof(bool), typeof(AttachedWindowData), new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.OverridesInheritanceBehavior));

        public static bool GetShowYes(DependencyObject obj) => (bool)obj.GetValue(ShowYesProperty);
        public static void SetShowYes(DependencyObject obj, bool value) => obj.SetValue(ShowYesProperty, value);

        public static readonly DependencyProperty ShowYesProperty =
            DependencyProperty.RegisterAttached("ShowYes", typeof(bool), typeof(AttachedWindowData), new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.OverridesInheritanceBehavior));

        public static bool GetShowNo(DependencyObject obj) => (bool)obj.GetValue(ShowNoProperty);
        public static void SetShowNo(DependencyObject obj, bool value) => obj.SetValue(ShowNoProperty, value);

        public static readonly DependencyProperty ShowNoProperty =
            DependencyProperty.RegisterAttached("ShowNo", typeof(bool), typeof(AttachedWindowData), new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.OverridesInheritanceBehavior));
    }
}
