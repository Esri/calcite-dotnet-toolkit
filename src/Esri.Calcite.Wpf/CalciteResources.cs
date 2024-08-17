using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Esri.Calcite.WPF
{
    /// <summary>
    /// Calcite resource dictionary that updates based on system theme
    /// </summary>
    public class CalciteResources : ResourceDictionary
    {
        internal static readonly System.Windows.Media.FontFamily CalciteUIFont = new System.Windows.Media.FontFamily(new Uri("pack://application:,,,/Esri.Calcite.WPF;component/Fonts/"), "./calcite-ui-icons.ttf#calcite-ui-icons");

        public CalciteResources()
        {
            //TODO: Use weak event handler
            Microsoft.Win32.SystemEvents.UserPreferenceChanging += SystemEvents_UserPreferenceChanging;
            UpdateResources();
        }

        private void SystemEvents_UserPreferenceChanging(object sender, Microsoft.Win32.UserPreferenceChangingEventArgs e)
        {
            if (e.Category == Microsoft.Win32.UserPreferenceCategory.General)
            {
                UpdateResources();
            }
        }

        private AppTheme m_Theme;

        public AppTheme Theme
        {
            get { return m_Theme; }
            set
            {
                if (m_Theme != value)
                {
                    m_Theme = value;
                    UpdateResources();
                }
            }
        }

        private void UpdateResources()
        {
            bool isDark = m_Theme == AppTheme.Dark;
            if(m_Theme == AppTheme.Default)
            {
                try
                {
                    isDark = (int?)Microsoft.Win32.Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", "AppsUseLightTheme", -1) != 1;
                }
                catch { }
            }
            if (isDark)
            {
                Source = new Uri("/Esri.Calcite.WPF;component/CalciteResourcesDark.xaml", UriKind.RelativeOrAbsolute);
            }
            else
            {
                Source = new Uri("/Esri.Calcite.WPF;component/CalciteResourcesLight.xaml", UriKind.RelativeOrAbsolute);
            }
        }

        private bool m_ApplyDefaultStyling = true;

        /// <summary>
        /// Gets or sets a property indicating whether default control styling should applied.
        /// </summary>
        public bool ApplyDefaultStyling
        {
            get { return m_ApplyDefaultStyling; }
            set
            {
                if (m_ApplyDefaultStyling != value)
                {
                    m_ApplyDefaultStyling = value;
                    var resourceoverride = MergedDictionaries.FirstOrDefault(d => d.Source.OriginalString.EndsWith("Overrides.xaml"));
                    if (resourceoverride is not null)
                    {
                        if (value)
                        {
                            resourceoverride.Source = new Uri("/Esri.Calcite.WPF;component/ControlOverrides.xaml", UriKind.RelativeOrAbsolute);
                        }
                        else if (!value)
                        {
                            resourceoverride.Source = new Uri("/Esri.Calcite.WPF;component/ControlNoOverrides.xaml", UriKind.RelativeOrAbsolute);
                        }
                    }
                }
            }
        }

    }

    public enum AppTheme
    {
        Default,
        Light,
        Dark
    }
}
