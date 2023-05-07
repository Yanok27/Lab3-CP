using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAB3_CP_.Models;

namespace LAB3_CP_.Data
{
    public interface IDContext
    {
        public IEnumerable<Motherboard> Motherboards => new List<Motherboard>();
        public IEnumerable<HardDrive> HardDrives => new List<HardDrive>();
        public IEnumerable<Memory> Memories => new List<Memory>();
        public IEnumerable<Processor> Processors => new List<Processor>();

    }
}
