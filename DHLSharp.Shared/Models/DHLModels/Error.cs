using System;
using System.Collections.Generic;
using System.Text;

namespace DHLSharp.Shared.Models.DHLModels
{
    public class Error
    {
        public string errorCode { get; set; }
        public string errorMessage { get; set; }
        public string errorPath { get; set; }
        public string errorId { get; set; }
        public string errorField { get; set; }
    }
}
