using System;
using System.Collections.Generic;
using System.Text;

namespace DHLSharp.Shared.Models.ResponseModels
{
    public class DHLResponse<T>
    {
        public object meta { get; set; }
        public T data { get; set; }
    }
}
