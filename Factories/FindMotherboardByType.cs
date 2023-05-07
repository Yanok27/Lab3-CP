using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAB3_CP_.Models;
using LAB3_CP_.Factories.Abstract;
using LAB3_CP_.Data;

namespace LAB3_CP_.Factories
{
    public class FindMotherboardByType:FindMotherboard
    {
        protected IDContext _dContext;
        public FindMotherboardByType(IDContext dContext)
        {
            _dContext = dContext;
        }

        public override IEnumerable<Motherboard> Find(object name)
        {
           var criterion = (string)name;
           return _dContext.Motherboards.Where(m => (m.Name).Contains((string)name)).ToList();
            
        }

        



    }
}
