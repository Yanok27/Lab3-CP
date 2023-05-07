using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAB3_CP_.Enums;

namespace LAB3_CP_.Models
{
    public class Memory:Product
    {
        public int Capacity { get; set; }
        public MemoryType MemoryType { get; set; }
        public int ClockSpeed { get; set; }
        public int Count { get; set; }
    }
}
