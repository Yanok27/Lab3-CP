using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAB3_CP_.Enums;

namespace LAB3_CP_.Models
{
    public class Motherboard:Product
    {
        
        public SocketType SocketType { get; set; }
        public ChipsetType Chipset { get; set; }
        public int ProcessorCount { get; set; }
        public MemoryType MemoryType { get; set; }
        public int BusSpeed { get; set; }

        public override string GetInfo()
        {
            return $"{SKU}-{Name}-{Price}-{SocketType}-{Chipset}-{ProcessorCount}-{MemoryType}-{BusSpeed}";
        }
    }
}
