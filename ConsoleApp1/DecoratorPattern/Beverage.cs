using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class Beverage
    {
        public abstract int GetCost();
        public abstract string GetDetail();
    }


    public class Espresso : Beverage
    {
        private int _cost;
        public Espresso()
        {
            _cost = 50;
        }
        public override int GetCost()
        {
            return _cost;
        }
        public override string GetDetail()
        {
            return $"Espresso Short";
        }
    }
    public class Cappuccino : Beverage
    {
        private int _cost;
        public Cappuccino()
        {
            _cost = 70;
        }
        public override int GetCost()
        {
            return _cost;
        }
        public override string GetDetail()
        {
            return $"Cappuccino Coffee";
        }
    }
    public class CondimentDecorator : Beverage
    {
        protected Beverage _beverage;
        public CondimentDecorator(Beverage beverage)
        {
            _beverage = beverage;
        }


        public override int GetCost()
        {
            return _beverage.GetCost();
        }
        public override string GetDetail()
        {
            return _beverage.GetDetail();
        }
    }
    public class Milk : CondimentDecorator
    {
        public Milk(Beverage beverage) : base(beverage) { }

        public override int GetCost()
        {
            return _beverage.GetCost() + 20;
        }
        public override string GetDetail()
        {
            return _beverage.GetDetail() + " | Add Milk + 20 |";
        }
    }

    public class Sugar : CondimentDecorator
    {

        public Sugar(Beverage beverage) : base(beverage) { }
        public override int GetCost()
        {
            return _beverage.GetCost() + 10;
        }
        public override string GetDetail()
        {
            return  _beverage.GetDetail() + " | Add Sugar + 10 | ";
        }
    }

    public class Caramel : CondimentDecorator
    {
        public Caramel(Beverage beverage) : base(beverage) { }
        public override int GetCost()
        {
            return _beverage.GetCost() + 60;
        }
        public override string GetDetail()
        {
            return _beverage.GetDetail() + " | Add Caramel  + 60 |";
        }
    }

}
