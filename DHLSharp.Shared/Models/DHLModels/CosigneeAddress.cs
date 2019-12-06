using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DHLSharp.Shared.Models.DHLModels
{
    public class CosigneeAddress : ShipmentAddress
    {
        /// <summary>
        /// Consignee's identification number
        /// </summary>
        [StringLength(30)]
        public string idNumber { get; set; }

        /// <summary>
        /// Denotes the type of identification number provided by the consignee for customs clearance and delivery. Note: Provide if available for DHL Parcel International Direct to S. Korea and China.
        /// 1 - National ID Number
        /// 2 - Military Number
        /// 3 - Passport Number
        /// 4 - Other
        /// </summary>
        [StringLength(2)]
        public string idType { get; set; }
        
        [StringLength(80)]
        public string email { get; set; }

        [StringLength(80)]
        public string phone { get; set; }
    }
}
