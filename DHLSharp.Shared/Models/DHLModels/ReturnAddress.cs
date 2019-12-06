using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DHLSharp.Shared.Models.DHLModels
{
    public class ReturnAddress : Address
    {
        /// <summary>
        /// The intended recipient of the returned package (e.g. Returns Department)
        /// </summary>
        [StringLength(30)]
        public string attention { get; set; }

    }
}
