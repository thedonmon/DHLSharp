using System;
using System.Collections.Generic;
using System.Text;

namespace DHLSharp.Shared.Models.DHLModels
{
    public class Package
    {
        /// <summary>
        ///  Total package weight
        /// </summary>
        public float weight { get; set; }

        /// <summary>
        ///  The unit of measure for the weight.
        /// </summary>
        public string weightUom { get; set; }
    }
}
