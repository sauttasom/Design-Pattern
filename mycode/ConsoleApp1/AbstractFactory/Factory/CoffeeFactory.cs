using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.AbstractFactory.ConcreteProduct;
using Assignment.AbstractFactory.Entity;

namespace Assignment.AbstractFactory.Factory
{
    public class DarkRoastFactory : CoffeeRoastFactory
    {
        public Robusta RoastRobusta()
        {
            return new DarkRoastRobusta();
        }
        public Arabica RoastArabica()
        {
            return new DarkRoastArabica();
        }
        public Geisha RoastGeisha()
        {
            return new DarkRoastGeisha();
        }
    }

    public class MediumFactory : CoffeeRoastFactory
    {
        public Robusta RoastRobusta()
        {
            return new MediumRoastRobusta();
        }
        public Arabica RoastArabica()
        {
            return new MediumRoastArabica();
        }
        public Geisha RoastGeisha()
        {
            return new MediumRoastGeisha();
        }
    }

    public class LightFactory : CoffeeRoastFactory
    {
        public Robusta RoastRobusta()
        {
            return new LigthRoastRobusta();
        }
        public Arabica RoastArabica()
        {
            return new LigthRoastArabica();
        }
        public Geisha RoastGeisha()
        {
            return new LigthRoastGeisha();
        }
    }
}
