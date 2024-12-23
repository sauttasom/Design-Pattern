using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.FactoryMethod
{
    internal class Example
    {

        public abstract class Discount
        {
            public abstract decimal GetPercentage();
        }
        public class RegularDiscount : Discount
        {
            public override decimal GetPercentage() => 0.1m;
        }
        public class IrregularDiscount : Discount
        {
            public override decimal GetPercentage() => 0.15m;
        }

        public abstract class DiscountPolicy
        {
            public abstract Discount Create();

            public decimal Apply(decimal Price)
            {
                var discount = Create();
                return Price * (1 - discount.GetPercentage());
            }

        }

        public class RegularDiscountPolicy : DiscountPolicy
        {
            public override Discount Create() => new RegularDiscount();
        }


        public class IrregularDiscountPolicy : DiscountPolicy
        {
            public override Discount Create() => new IrregularDiscount();
        }

        public class Order
        {
            private readonly decimal _netAmount;
            public decimal Amount => OrderDiscountPolicy.Apply(_netAmount);
            public DiscountPolicy OrderDiscountPolicy
            {
                get; private set;
            }
            public Order(decimal amount, DiscountPolicy discountPolicy)
            {
                _netAmount = amount;
                OrderDiscountPolicy = discountPolicy;
            }
        }

        //public class Program
        //{
        //    public static void Main()
        //    {
        //        var order = new Order(1000, new IrregularDiscountPolicy());
        //        Console.WriteLine(order.Amount);
        //    }
        //}
    }
}
