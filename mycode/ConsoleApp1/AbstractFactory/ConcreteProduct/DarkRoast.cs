using Assignment.AbstractFactory.Entity;
using Assignment.AbstractFactory.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.AbstractFactory.ConcreteProduct
{
    public class DarkRoastRobusta : Robusta
    {
        public override void make() => Console.WriteLine("DarkRoast : Robusta");

    }
    public class DarkRoastArabica : Arabica
    {
        public override void make() => Console.WriteLine("DarkRoast : Arabica");

    }
    public class DarkRoastGeisha : Geisha
    {
        public override void make() => Console.WriteLine("DarkRoast : Geisha");
    }
}
