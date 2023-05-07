using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAB3_CP_.Enums;

namespace LAB3_CP_.Models
{
    public class Processor:Product
    {
        public ConnectorType ConnectorType { get; set; }
        public int CoreCount { get; set; }
        public double ClockSpeed { get; set; }
    }
}
