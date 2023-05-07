using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAB3_CP_.Enums;

namespace LAB3_CP_.Models
{
    public class Processor:IProduct
    {
        public string Name { get; set; }
        public string SKU { get; set; }
        public decimal Price { get; set; }
        public ConnectorType ConnectorType { get; set; }
        public int CoreCount { get; set; }
        public double ClockSpeed { get; set; }

        public IProduct Find(string name, string SKU, decimal price)
        {
            throw new NotImplementedException();
        }

        public string GetInfo()
        {
            throw new NotImplementedException();
        }
    }
}
