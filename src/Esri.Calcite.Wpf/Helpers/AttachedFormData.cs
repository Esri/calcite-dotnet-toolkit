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
    public static class AttachedFormData
    {
        public static bool GetIsInForm(DependencyObject obj) => (bool)obj.GetValue(IsInFormProperty);
        public static void SetIsInForm(DependencyObject obj, bool value) => obj.SetValue(IsInFormProperty, value);

        public static readonly DependencyProperty IsInFormProperty =
            DependencyProperty.RegisterAttached("IsInForm", typeof(bool), typeof(AttachedFormData), new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.Inherits));
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
