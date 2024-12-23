using Assignment.AbstractFactory.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.AbstractFactory
{
    public interface CoffeeRoastFactory
    {
        public Robusta RoastRobusta();
        public Arabica RoastArabica();
        public Geisha RoastGeisha();
    }

    
}
