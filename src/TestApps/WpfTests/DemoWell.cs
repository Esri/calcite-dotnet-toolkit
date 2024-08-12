using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xaml;

namespace WpfTests
{
    /// <summary>
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:WpfDemo"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:WpfDemo;assembly=WpfDemo"
    ///
    /// You will also need to add a project reference from the project where the XAML file lives
    /// to this project and Rebuild to avoid compilation errors:
    ///
    ///     Right click on the target project in the Solution Explorer and
    ///     "Add Reference"->"Projects"->[Browse to and select this project]
    ///
    ///
    /// Step 2)
    /// Go ahead and use your control in the XAML file.
    ///
    ///     <MyNamespace:DemoWell/>
    ///
    /// </summary>
    [TemplatePart(Name = "PART_CodeDisplay", Type = typeof(TextBox))]
    [TemplatePart(Name = "PART_RenderDisplay", Type = typeof(Grid))]
    [TemplatePart(Name = "PART_CopyButton", Type = typeof(Button))]
    [TemplatePart (Name = "PART_StatusPopup", Type=typeof(Popup))]
    public class DemoWell : ContentControl
    {
        private TextBox? _richText;
        private Grid? _renderDisplay;
        private Button? _copyButton;
        private UIElement? _renderedContent;
        private Popup _statusPopup;
        private string? _textContent;
        static DemoWell()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DemoWell), new FrameworkPropertyMetadata(typeof(DemoWell)));
        }
        public DemoWell() : base()
        {
            DefaultStyleKey = typeof(DemoWell);
        }

        public override void OnApplyTemplate()
        {
            if (_copyButton != null)
            {
                _copyButton.Click -= _copyButton_Click;
                _copyButton = null;
            }
            if (_statusPopup != null)
            {
                _statusPopup = null;
            }
            base.OnApplyTemplate();

            _richText = GetTemplateChild("PART_CodeDisplay") as TextBox;
            _renderDisplay = GetTemplateChild("PART_RenderDisplay") as Grid;
            if (_renderedContent != null && _renderDisplay != null)
            {
                _renderDisplay.Children.Clear();
                _renderDisplay.Children.Add(_renderedContent);
            }
            if (_richText != null && _textContent != null)
            {
                _richText.Text = _textContent;
            }

            if (GetTemplateChild("PART_CopyButton") is Button copyButton)
            {
                _copyButton = copyButton;
                _copyButton.Click += _copyButton_Click;
            }
            if (GetTemplateChild("PART_StatusPopup") is Popup statusPopup)
            {
                _statusPopup = statusPopup;
            }
        }

        private void _copyButton_Click(object sender, RoutedEventArgs e)
        {
            if (_richText?.Text != null)
            {
                Clipboard.SetText(_richText.Text);
                _statusPopup.IsOpen = true;
                Task.Delay(2000).ContinueWith(_ => Dispatcher.Invoke(() => _statusPopup.IsOpen = false));
            }
        }

        public string? SampleXamlPath
        {
            get => GetValue(SampleXamlPathProperty) as string;
            set => SetValue(SampleXamlPathProperty, value);
        }

        public static readonly DependencyProperty SampleXamlPathProperty =
            DependencyProperty.Register(nameof(SampleXamlPath), typeof(string), typeof(DemoWell), new PropertyMetadata(null, OnSamplePathChanged));

        private static void OnSamplePathChanged(DependencyObject o, DependencyPropertyChangedEventArgs e)
        {
            try
            {

                if (o is DemoWell dw && e.NewValue is string path)
                {
                    StreamReader reader = new StreamReader(path);
                    var outputObject = System.Windows.Markup.XamlReader.Load(reader.BaseStream);
                    if (outputObject is UIElement childElement)
                    {
                        dw._renderedContent = childElement;
                        if (dw._renderDisplay != null)
                        {
                            dw._renderDisplay.Children.Clear();
                            dw._renderDisplay.Children.Add(childElement);
                        }
                    }
                    dw._textContent = File.ReadAllText(path).Replace(" xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\"", "");
                    if (dw._richText != null)
                    {
                        dw._richText.Text = dw._textContent;
                    }
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
