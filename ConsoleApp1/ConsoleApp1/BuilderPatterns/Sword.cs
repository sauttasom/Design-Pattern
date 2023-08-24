using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.BuilderPatterns
{
    public class Sword
    {

        private string  _Swordtype { get; set; }
        private bool plasticBuild { get; set; }
        private bool SteelBuild { get; set; }

        public Sword() {
            plasticBuild = false;
            SteelBuild = false;
            _Swordtype = string.Empty;
        }
        public void setEngraveAndCoat()
        {
            Console.WriteLine("SwordBuilder : BuildEngraveAndCoat");
        }
        public void  setSwordType(string type)
        {
            _Swordtype = type;
            Console.WriteLine("SwordBuilder : buildSwordtype");
        }
        public void setMaterial(bool plastic , bool steel)
        {
            plasticBuild = plastic;
            SteelBuild = steel;
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
            Console.WriteLine($"Sword Type {_Swordtype}");
            if (this.SteelBuild)
            {
                Console.WriteLine($"Sword BuildMaterial is Steel Sword");
            }
            if(this.plasticBuild)
            {
                Console.WriteLine($"Sword BuildMaterial is Toy Plastic  Sword");
            }
         
        }
    }
}
