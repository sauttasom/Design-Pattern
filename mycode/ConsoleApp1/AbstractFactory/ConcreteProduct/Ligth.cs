using Assignment.AbstractFactory.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.AbstractFactory.ConcreteProduct
{
 
    public class LigthRoastRobusta :Robusta
    {
        public override  void make()
        {
            Console.WriteLine("LigthRoast : Robusta");
        }
    }
    public class LigthRoastArabica : Arabica
    {
        public override  void make()
        {
            Console.WriteLine("LigthRoast : Arabica");
        }
    }
    public class LigthRoastGeisha : Geisha
    {
        public  override void make()
        {
            Console.WriteLine("LigthRoast : Geisha");
        }
    }
}
