using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.BuilderPatterns
{
    public class Director
    {
        public void MakeKatana(IBuilder builder)
        {
            Console.WriteLine("--------- Create : Katana  ----------");
            builder.BuildTemplate();
            builder.BuildMaterial();
            builder.BuildDecoration();
            builder.BuildEngraveAndCoat();
            builder.BuildPerformCasting();
          
        }
        public void MakeBroadSword(IBuilder builder)
        {
            Console.WriteLine("--------- Create : BroadSword  ----------");
            builder.BuildTemplate();
            builder.BuildMaterial();
            builder.BuildDecoration();
            builder.BuildEngraveAndCoat();
            builder.BuildPerformCasting();
           
        }
   
         public void MakeKrabi(IBuilder builder)
        {
            Console.WriteLine("--------- Create : Krabi  ----------");
            builder.BuildTemplate();
            builder.BuildMaterial();
            builder.BuildPerformCasting();
            
        }
    }
}
