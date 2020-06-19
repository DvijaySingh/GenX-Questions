using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ConsoleApp1
{
    class Product
    {
        public int Qty { get; set; }
        public decimal Rate { get; set; }
        [JsonIgnore]
        public decimal TotalPrice { get { return Qty* Rate;  } }

    }
}
