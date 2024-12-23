using Assignment.AbstractFactory.ConcreteProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.BuilderPatterns
{
    public class Toy
    {

        public bool PlasticMaterial { get; set; }

        public bool Ligth { get; set; }
        public bool Sound { get; set; }

        public Toy()
        {
            PlasticMaterial = false;
            Sound = false;
            Ligth = false;
        }
        public void setEngraveAndCoat()
        {
            Console.WriteLine("SwordBuilder : BuildEngraveAndCoat");
        }
        public void setTsuba()
        {
            Console.WriteLine("SwordBuilder : BuildTsuba");
        }
        public void setSwordType()
        {
            
            Console.WriteLine("SwordBuilder : buildSwordtype");
        }
        public void setMaterial(bool sound, bool ligth)
        {
            PlasticMaterial = true;
            Sound = sound;
            Ligth = ligth;
        }

        public void setDecoration()
        {
            Console.WriteLine("SwordBuilder : BuildDecoration");
        }

        public void setTemplate()
        {
            Console.WriteLine("SwordBuilder : BuildTemplate");
        }

        public void setPerformCasting()
        {
            Console.WriteLine("SwordBuilder : BuildPerformCasting");
        }



        public void Show()
        {
            Console.WriteLine($"--------Toy Sword----------------");
            Console.WriteLine($"Sword BuildMaterial is Plastic Material");
            if (Sound) Console.WriteLine("Sword have Sound Function");
            if (Ligth) Console.WriteLine("Sword have Ligth Function");
        }
    }
}
