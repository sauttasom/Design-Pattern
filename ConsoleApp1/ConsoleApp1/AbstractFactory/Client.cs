using Assignment.AbstractFactory.ConcreteProduct;
using Assignment.AbstractFactory.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.AbstractFactory
{
    public class Client
    {
        private CoffeeRoastFactory coffeeRoastFactory;
        public Client(CoffeeRoastFactory coffeeRoastFactory)
        {
            this.coffeeRoastFactory = coffeeRoastFactory;
        }
        public void makeCoffee()
        {

            var robusta = coffeeRoastFactory.RoastRobusta();
            var arabica = coffeeRoastFactory.RoastArabica();
            var geisha = coffeeRoastFactory.RoastGeisha();
            Console.WriteLine($"------Plase Wait Coffee Order  -----------");
            robusta.make();
            arabica.make();
            geisha.make();
            Console.WriteLine("------ Coffee Order Success -----------");
        }
    }
}
