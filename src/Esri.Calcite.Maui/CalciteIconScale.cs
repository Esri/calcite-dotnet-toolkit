using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esri.Calcite.Maui
{
    /// <summary>
    /// Calcite Icon scale. Why 3 Sizes? More info on what happens when you scale vector based icons <see cref="https://github.com/Esri/calcite-ui-icons/wiki/What-Happens-When-You-Scale-Vector-Based-Icons">here</see>.
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
