using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.FactoryMethod
{


    public abstract class IShipping
    {
        public abstract void Deliver();
    }

    public class Truck : IShipping
    {
        public override void Deliver() => Console.WriteLine("Truck  => Delivered By Truck");
    }
    public class Boat : IShipping
    {
        public override void Deliver() => Console.WriteLine("Boat => Delivered By Boat");
    }

    public abstract class ShippingSystem
    {
        public abstract IShipping CreateTransport();
        public void Apply()
        {
            var shipping = CreateTransport();
            shipping.Deliver();
        }
    }
    public class TruckTransport : ShippingSystem
    {
        public override IShipping CreateTransport() => new Truck();

    }
    public class BoatTransport : ShippingSystem
    {
        public override IShipping CreateTransport() => new Boat();

    }
}
