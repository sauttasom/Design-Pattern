using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Element;

namespace Visitor
{
    public interface IVisitor
    {
        public void VisitReebok(Reebok reebok);
        public void VisitPuma(Puma puma);
        public void VisitAdidas(Adidas adidas);
        public void VisitNike(Nike nike);
    }


    public class UpgradShoesVisitor : IVisitor
    {
        public void VisitReebok(Reebok reebok)
        {
            Console.WriteLine($"Reebok Name  before :  {reebok.Name} ");
            Console.WriteLine($"Upgrad  Reebok Coler before :  {reebok.Coler} ");

            reebok.Coler = "Yellow";
            Console.WriteLine($"Upgrad Reebok Coler after :  {reebok.Coler}");
            Console.WriteLine("\n");
        }
        public void VisitPuma(Puma puma)
        {
            Console.WriteLine($"Puma Name   :  {puma.Name} ");
            Console.WriteLine($"Upgrad  Puma Coler before :  {puma.Coler} ");
            puma.Coler = "Yellow";
            Console.WriteLine($"Upgrad Puma Coler after :  {puma.Coler}");
            Console.WriteLine("\n");
        }
        public void VisitAdidas(Adidas adidas)
        {
            Console.WriteLine($"Adidas Name  :  {adidas.Name} ");
            Console.WriteLine($"Upgrad  Adidas Coler before :  {adidas.Coler} ");
            adidas.Coler = "Yellow";
            Console.WriteLine($"Upgrad Adidas Coler after :  {adidas.Coler}");
            Console.WriteLine("\n");
        }
        public void VisitNike(Nike nike)
        {
            Console.WriteLine($"Nike Name  before :  {nike.Name} ");
            Console.WriteLine($"Upgrad  Nike Coler before :  {nike.Coler} ");
            nike.Coler = "Yellow";
            Console.WriteLine($"Upgrad Nike Coler after :  {nike.Coler}");
            Console.WriteLine("\n");
        }
    }

}
