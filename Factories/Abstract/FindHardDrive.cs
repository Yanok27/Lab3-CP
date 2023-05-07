using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAB3_CP_.Models;
using LAB3_CP_.Factories.Abstract;

namespace LAB3_CP_.Factories.Abstract
{
    public abstract class FindHardDrive:IFindConfiguration<HardDrive>
    {
        public abstract IEnumerable<HardDrive> Find(object criterion);
       
    }
}
