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

namespace Esri.Calcite.WPF
{
    /// <summary>
    /// Calcite Icon scale. Why 3 Sizes? More info on what happens when you scale vector based icons <see href="https://github.com/Esri/calcite-ui-icons/wiki/What-Happens-When-You-Scale-Vector-Based-Icons">here</see>.
    /// </summary>
    public enum CalciteIconScale
    {
        /// <summary>
        /// Icon scale detail usable for small icons
        /// </summary>
        Small = 0,
        /// <summary>
        /// Icon scale detail usable for medium sized icons
        /// </summary>
        Medium = 1,
        /// <summary>
        /// Icon scale detail usable for large icons
        /// </summary>
        Large = 2
    }
}
