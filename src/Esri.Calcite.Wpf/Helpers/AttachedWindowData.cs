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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Esri.Calcite.WPF.Helpers
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    [System.ComponentModel.Browsable(false)]
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public static class AttachedWindowData
    {
        public static FrameworkElement? GetWindowTitleBarCenteredInset (DependencyObject obj) => obj.GetValue(WindowTitleBarCenteredInsetProperty) as FrameworkElement;
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
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
