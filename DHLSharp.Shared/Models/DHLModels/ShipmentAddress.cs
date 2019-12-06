using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DHLSharp.Shared.Models.DHLModels
{
    public class ShipmentAddress : Address
    {
        
        /// <summary>
        /// Name of the institution receiving/returning the shipment
        /// </summary>
        [StringLength(30, ErrorMessage = "Company Name field must be maximum of 30 characters")]
        public string companyName { get; set; }

        /// <summary>
        /// (International Only) Line 3 of the street address or delivery location - typically used for addresses to designate province, district, or neighborhood
        /// </summary>
        [StringLength(40, ErrorMessage = "Address3 field must be maximum of 40 characters")]
        public string address3 { get; set; }


    }
}
