using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3_CP_.Models
{
    public interface IProduct
    {
        public string Name { get; set; }
        public string SKU { get; set; }
        public decimal Price { get; set; }

        public IProduct Find(string name, string SKU, decimal price);

        public string GetInfo();
    }
}
