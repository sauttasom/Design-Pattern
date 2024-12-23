using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.BuilderPatterns
{
    public class Sword
    {

        private bool SteelMaterial { get; set; }
        private bool Saya { get; set; }
        private bool TitaniumMaterial { get; set; }
        public Sword() {

            SteelMaterial = true;
            TitaniumMaterial = false;
            Saya = false;
        }   
        public void setEngraveAndCoat()
        {
            Console.WriteLine("SwordBuilder : BuildEngraveAndCoat");
        }
        
        public void setTsuba()
        {
           
            Console.WriteLine("SwordBuilder : buildTsuba");
        }
        public void setMaterial(bool titanium ,bool saya)
        {

            if (!titanium)
            {
                SteelMaterial = true;
            }
            else
            {
                TitaniumMaterial = titanium;
            }
            Saya = saya;

            Console.WriteLine("SwordBuilder : buildMaterial");
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
            
            Console.WriteLine($"--------Sword----------------");
            if (TitaniumMaterial) Console.WriteLine("Sword Buiding  TitaniumMaterial  ");
            if (SteelMaterial) Console.WriteLine("Sword Buiding SteelMaterial ");
            if (Saya) Console.WriteLine("Sword have Saya ");
        }
    }
}
