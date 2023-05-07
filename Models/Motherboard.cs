using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAB3_CP_.Enums;

namespace LAB3_CP_.Models
{
    public class Motherboard:IProduct
    {
        public string Name { get; set; }
        public string SKU { get; set; }
        public decimal Price { get; set; }
        public SocketType SocketType { get; set; }
        public ChipsetType Chipset { get; set; }
        public int ProcessorCount { get; set; }
        public MemoryType MemoryType { get; set; }
        public int BusSpeed { get; set; }

        public IProduct Find(string name, string SKU, decimal price)
        {
            throw new NotImplementedException();
        }

        public string GetInfo()
        {
            return $"{SKU}-{Name}-{Price}-{SocketType}-{Chipset}-{ProcessorCount}-{MemoryType}-{BusSpeed}";
        }
    }
}
