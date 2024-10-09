using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.Prototype
{
    public class Mlieko : IPrototype
    {
        public string Manufacturer { get; set; }
        public DateTime ExpirationDate { get; set; }
        public decimal Price { get; set; }

        public IPrototype Clone()
        {
            return new Mlieko
            {
                Manufacturer = Manufacturer,
                ExpirationDate = ExpirationDate,
                Price = Price
            };
        }
    }
}
