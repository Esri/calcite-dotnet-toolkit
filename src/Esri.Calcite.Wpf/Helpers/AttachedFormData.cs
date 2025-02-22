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
    public static class AttachedFormData
    {
        public static bool GetIsInForm(DependencyObject obj) => (bool)obj.GetValue(IsInFormProperty);
        public static void SetIsInForm(DependencyObject obj, bool value) => obj.SetValue(IsInFormProperty, value);

        public static readonly DependencyProperty IsInFormProperty =
            DependencyProperty.RegisterAttached("IsInForm", typeof(bool), typeof(AttachedFormData), new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.Inherits));
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
