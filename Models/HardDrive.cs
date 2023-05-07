using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAB3_CP_.Enums;

namespace LAB3_CP_.Models
{
    public class HardDrive:IProduct
    {
        public string Name { get; set; }
        public string SKU { get; set; }
        public decimal Price { get; set; }
        public int Capacity { get; set; }
        public int Speed { get; set; }
        public InterfaceType Interface { get; set; }

        public IProduct Find(string name, string SKU, decimal price)
        {
            throw new NotImplementedException();
        }


        public string GetInfo()
        {
            return $"{Name}, SKU: {SKU}, Price: {Price}, Capacity: {Capacity}, Speed: {Speed}, Interface type: {Interface}";
        }
    }
}
