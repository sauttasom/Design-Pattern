using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class Coffee
    {
        public abstract int GetCost();
        public abstract string GetDetail();
    }


    public class Espresso : Coffee
    {
        private int _cost;
        public Espresso()
        {
            _cost = 45;
        }
        public override int GetCost()
        {
            return _cost;
        }
        public override string GetDetail()
        {
            return $"Espresso Short 45 Baht";
        }
    }

    public class ComponentDecorator : Coffee
    {
        protected Coffee _coffee;
        public ComponentDecorator(Coffee beverage)
        {
            _coffee = beverage;
        }

        public override int GetCost()
        {
            return _coffee.GetCost();
        }
        public override string GetDetail()
        {
            return _coffee.GetDetail();
        }
    }

    public class Milk : ComponentDecorator
    {
        private int _milk = 20;
        public Milk(Coffee coffee) : base(coffee) {
        }

        public override int GetCost()
        {
            return _coffee.GetCost() + _milk;
        }
        public override string GetDetail()
        {
            return "Add Milk + 20/Baht";
        }
    }
    public class Chocolate : ComponentDecorator
    {
        private int _chocolate = 30;
        public Chocolate(Coffee beverage) : base(beverage) { }

        public override int GetCost()
        {
            return _coffee.GetCost() + _chocolate;
        }
        public override string GetDetail()
        {
            return  "Add Chocolate + 30/Baht";
        }
    }
    public class WhippedCream : ComponentDecorator
    {
        public WhippedCream(Coffee beverage) : base(beverage) { }

        public override int GetCost()
        {
            return _coffee.GetCost() + 20;
        }
        public override string GetDetail()
        {
            return "Add WhippedCream + 20/Baht";
        }
    }


    public class Caramel : ComponentDecorator
    {
        public Caramel(Coffee beverage) : base(beverage) { }
        public override int GetCost()
        {
            return _coffee.GetCost() + 60;
        }
        public override string GetDetail()
        {
            return "Add Caramel  + 60/Baht";
        }
    }

}
