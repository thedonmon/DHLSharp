using System.ComponentModel.DataAnnotations;

namespace DHLSharp.Shared.Models.DHLModels
{
    public class Address
    {
        /// <summary>
        /// Name of the person receiving/returning the shipment
        /// </summary>
        [StringLength(30, ErrorMessage = "Name field must be maximum of 30 characters")]
        public string name { get; set; }

        /// <summary>
        /// Line 1 of the street address or delivery location
        /// </summary>
        [StringLength(40, ErrorMessage = "Address1 field must be maximum of 40 characters")]
        public string address1 { get; set; }

        /// <summary>
        ///  Line 2 of the street address or delivery location
        /// </summary>
        [StringLength(40, ErrorMessage = "Address2 field must be maximum of 40 characters")]
        public string address2 { get; set; }

        /// <summary>
        /// Consignee's city
        /// </summary>
        [StringLength(30, ErrorMessage = "City field must be maximum of 30 characters")]
        public string city { get; set; }

        /// <summary>
        /// Address state, province or territory.
        /// </summary>
        [StringLength(2, ErrorMessage = "State must be in ISO2 Format")]
        public string state { get; set; }

        /// <summary>
        /// Addresss postal code
        /// </summary>
        [StringLength(11, MinimumLength = 5, ErrorMessage = "Postal Code must be between 5 and 11 characters")]
        public string postalCode { get; set; }

        /// <summary>
        /// Two-character ISO address country code.
        /// </summary>
        [StringLength(2, ErrorMessage = "Country must be in ISO2 Format")]
        public string country { get; set; }
    }
}