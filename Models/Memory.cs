using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using LAB3_CP_.Data;
using LAB3_CP_.Enums;

namespace LAB3_CP_.Models
{
    public class Memory:IProduct
    {
        public string Name { get; set; }
        public string SKU { get; set; }
        public decimal Price { get; set; }
        public int Capacity { get; set; }
        public MemoryType MemoryType { get; set; }
        public int ClockSpeed { get; set; }
        public int Count { get; set; }
        public IProduct Find(string name, string sku, decimal price)
        {
            var _context = new DataContext();
            var foundProduct = _context
                .Memories
                .Where(product => product.Name == name)
                .Where(product => product.SKU == sku)
                .Where(product => product.Price == price)
                .FirstOrDefault();

            return foundProduct;
        }

        public string GetInfo()
        {
            return $"{SKU}-{Name}-{Price}-{Capacity}-{MemoryType}-{ClockSpeed}-{Count}";
        }
    }
}
