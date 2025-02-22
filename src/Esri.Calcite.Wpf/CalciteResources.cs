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
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace Esri.Calcite.WPF
{
    /// <summary>
    /// Calcite resource dictionary that updates based on system theme
    /// </summary>
    public class CalciteResources : ResourceDictionary
    {
        internal static readonly System.Windows.Media.FontFamily CalciteUISmallFont = new System.Windows.Media.FontFamily(new Uri("pack://application:,,,/Esri.Calcite.WPF;component/Fonts/"), "./calcite-ui-icons-16.ttf#calcite-ui-icons-16");
        internal static readonly System.Windows.Media.FontFamily CalciteUIMediumFont = new System.Windows.Media.FontFamily(new Uri("pack://application:,,,/Esri.Calcite.WPF;component/Fonts/"), "./calcite-ui-icons-24.ttf#calcite-ui-icons-24");
        internal static readonly System.Windows.Media.FontFamily CalciteUILargeFont = new System.Windows.Media.FontFamily(new Uri("pack://application:,,,/Esri.Calcite.WPF;component/Fonts/"), "./calcite-ui-icons-32.ttf#calcite-ui-icons-32");

        private readonly WeakEventListener<CalciteResources, object, object, Microsoft.Win32.UserPreferenceChangingEventArgs> userPreferenceHandler;
        private readonly Dispatcher _CurrentDispatcher;

        /// <summary>
        /// Initializes a new instance of the <see cref="CalciteResources"/> class.
        /// </summary>
        public CalciteResources()
        {
            userPreferenceHandler = new WeakEventListener<CalciteResources, object, object, Microsoft.Win32.UserPreferenceChangingEventArgs>(this, null);
            userPreferenceHandler.OnEventAction = (instance, sender, e) => SystemEvents_UserPreferenceChanging(e);
            userPreferenceHandler.OnDetachAction = (instance, source, weakListener) => Microsoft.Win32.SystemEvents.UserPreferenceChanging -= userPreferenceHandler.OnEvent;
            Microsoft.Win32.SystemEvents.UserPreferenceChanging += userPreferenceHandler.OnEvent;
            _CurrentDispatcher = Dispatcher.CurrentDispatcher;
            UpdateResources();
        }

        private void SystemEvents_UserPreferenceChanging(Microsoft.Win32.UserPreferenceChangingEventArgs e)
        {
            if (e.Category == Microsoft.Win32.UserPreferenceCategory.General && m_Theme == AppTheme.Default &&
                _CurrentDispatcher != null && !_CurrentDispatcher.HasShutdownStarted && !_CurrentDispatcher.HasShutdownFinished)
            {
                _CurrentDispatcher.BeginInvoke(new Action(() => UpdateResources()));
            }
        }

        private AppTheme m_Theme;

        /// <summary>
        /// Gets or sets the theme for the resources.
        /// </summary>
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
            ApplyDefaultStyling(IsCalciteImplicitStylingEnabled);
        }

        private bool m_IsCalciteImplicitStylingEnabled = true;

        /// <summary>
        /// Gets or sets a property indicating whether default calcite styling should be applied implicitly.
        /// </summary>
        public bool IsCalciteImplicitStylingEnabled
        {
            get { return m_IsCalciteImplicitStylingEnabled; }
            set
            {
                if (m_IsCalciteImplicitStylingEnabled != value)
                {
                    m_IsCalciteImplicitStylingEnabled = value;
                    ApplyDefaultStyling(value);
                }
            }
        }

        private void ApplyDefaultStyling(bool value)
        {
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

    /// <summary>
    /// Theme for the application
    /// </summary>
    /// <seealso cref="CalciteResources.Theme"/>
    public enum AppTheme
    {
        /// <summary>
        /// Defaults to the system theme
        /// </summary>
        Default,
        /// <summary>
        /// Light theme
        /// </summary>
        Light,
        /// <summary>
        /// Dark theme
        /// </summary>
        Dark
    }
}
