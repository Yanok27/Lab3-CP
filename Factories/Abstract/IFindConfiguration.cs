using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAB3_CP_.Models;

namespace LAB3_CP_.Factories.Abstract
{
    public abstract class FindConfiguration
    {
        public abstract IProduct FactoryMethod();
        public IProduct Find(string name, string sku, decimal price)
        {
            var product = FactoryMethod();
            return product.Find(name, sku, price);
        }
       
    }
}
