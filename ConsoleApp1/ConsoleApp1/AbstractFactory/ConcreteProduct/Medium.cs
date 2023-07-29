using Assignment.AbstractFactory.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.AbstractFactory.ConcreteProduct
{
 
    public class MediumRoastRobusta :Robusta
    {
        public override void make()
        {
            Console.WriteLine("MediumRoast : Robusta");
        }
    }
    public class MediumRoastArabica : Arabica
    {
        public override void make()
        {
            Console.WriteLine("MediumRoast : Arabica");
        }
    }
    public class MediumRoastGeisha : Geisha
    {
        public override  void make()
        {
            Console.WriteLine("MediumRoast : Geisha");
        }
    }

}
