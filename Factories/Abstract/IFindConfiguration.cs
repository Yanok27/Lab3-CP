using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAB3_CP_.Models;

namespace LAB3_CP_.Factories.Abstract
{
    public interface IFindConfiguration<TElement>
    {
        public IEnumerable<TElement> Find(object criterion);
       
    }
}
