using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Element
{
    public interface IShoes
    {
        public void Accept(IVisitor visitor);

    }

    public class Reebok : IShoes
    {
        public string Name = "Reebok classic";
        public string Coler = "Red";
        public void Accept(IVisitor visitor)
        {
            visitor.VisitReebok(this);
        }
    }
    public class Nike : IShoes
    {
        public string Name = "Nike Air Max";
        public string Coler = "Red";

        public void Accept(IVisitor visitor)
        {
            visitor.VisitNike(this);
        }
    }
    public class Adidas : IShoes
    {
        public string Name = "Adidas superstar";
        public string Coler = "Red";
        public void Accept(IVisitor visitor)
        {
            visitor.VisitAdidas(this);
        }
    }
    public class Puma : IShoes
    {
        public string Name = "Puma sneakers";
        public string Coler = "Red";
        public void Accept(IVisitor visitor)
        {
            visitor.VisitPuma(this);
        }
    }
}
