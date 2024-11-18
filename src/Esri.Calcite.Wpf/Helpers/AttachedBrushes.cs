using System.Windows;
using System.Windows.Media;

namespace Esri.Calcite.WPF.Helpers
{
    /// <summary>
    /// A set of attached properties for brushes that are used to control style behaviors in the controls.
    /// </summary>
    [System.ComponentModel.Browsable(false)]
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public static class AttachedBrushes
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static Brush GetForegroundNormal(DependencyObject obj) => (Brush)obj.GetValue(ForegroundNormalProperty);
        public static void SetForegroundNormal(DependencyObject obj, Brush value) => obj.SetValue(ForegroundNormalProperty, value);

        public static readonly DependencyProperty ForegroundNormalProperty =
            DependencyProperty.RegisterAttached("ForegroundNormal", typeof(Brush), typeof(AttachedBrushes), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));
        public static Brush GetForegroundHover(DependencyObject obj) => (Brush)obj.GetValue(ForegroundHoverProperty);
        public static void SetForegroundHover(DependencyObject obj, Brush value) => obj.SetValue(ForegroundHoverProperty, value);

        public static readonly DependencyProperty ForegroundHoverProperty =
            DependencyProperty.RegisterAttached("ForegroundHover", typeof(Brush), typeof(AttachedBrushes), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));
        public static Brush GetForegroundPress(DependencyObject obj) => (Brush)obj.GetValue(ForegroundPressProperty);
        public static void SetForegroundPress(DependencyObject obj, Brush value) => obj.SetValue(ForegroundPressProperty, value);

        public static readonly DependencyProperty ForegroundPressProperty =
            DependencyProperty.RegisterAttached("ForegroundPress", typeof(Brush), typeof(AttachedBrushes), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));
        public static Brush GetBackgroundNormal(DependencyObject obj) => (Brush)obj.GetValue(BackgroundNormalProperty);
        public static void SetBackgroundNormal(DependencyObject obj, Brush value) => obj.SetValue(BackgroundNormalProperty, value);

        public static readonly DependencyProperty BackgroundNormalProperty =
            DependencyProperty.RegisterAttached("BackgroundNormal", typeof(Brush), typeof(AttachedBrushes), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));
        public static Brush GetBackgroundHover(DependencyObject obj) => (Brush)obj.GetValue(BackgroundHoverProperty);
        public static void SetBackgroundHover(DependencyObject obj, Brush value) => obj.SetValue(BackgroundHoverProperty, value);

        public static readonly DependencyProperty BackgroundHoverProperty =
            DependencyProperty.RegisterAttached("BackgroundHover", typeof(Brush), typeof(AttachedBrushes), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));
        public static Brush GetBackgroundPress(DependencyObject obj) => (Brush)obj.GetValue(BackgroundPressProperty);
        public static void SetBackgroundPress(DependencyObject obj, Brush value) => obj.SetValue(BackgroundPressProperty, value);

        public static readonly DependencyProperty BackgroundPressProperty =
            DependencyProperty.RegisterAttached("BackgroundPress", typeof(Brush), typeof(AttachedBrushes), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));
        public static Brush GetBorderNormal(DependencyObject obj) => (Brush)obj.GetValue(BorderNormalProperty);
        public static void SetBorderNormal(DependencyObject obj, Brush value) => obj.SetValue(BorderNormalProperty, value);

        public static readonly DependencyProperty BorderNormalProperty =
            DependencyProperty.RegisterAttached("BorderNormal", typeof(Brush), typeof(AttachedBrushes), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));
        public static Brush GetBorderHover(DependencyObject obj) => (Brush)obj.GetValue(BorderHoverProperty);
        public static void SetBorderHover(DependencyObject obj, Brush value) => obj.SetValue(BorderHoverProperty, value);

        public static readonly DependencyProperty BorderHoverProperty =
            DependencyProperty.RegisterAttached("BorderHover", typeof(Brush), typeof(AttachedBrushes), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));
        public static Brush GetBorderPress(DependencyObject obj) => (Brush)obj.GetValue(BorderPressProperty);
        public static void SetBorderPress(DependencyObject obj, Brush value) => obj.SetValue(BorderPressProperty, value);

        public static readonly DependencyProperty BorderPressProperty =
            DependencyProperty.RegisterAttached("BorderPress", typeof(Brush), typeof(AttachedBrushes), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
