using Assignment.Adapter.AdapterClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Adapter.TargetClass
{
    public class Car : Vehicle
    {


        public double Price { get; set; }
        public string SteeringWheel { get; set; }
        private static int _count = 0;
       
        public Car(string w, string bodyValue, string colorValue, string mirrorValue, double priceValue, string SteeringWheelValue)
          : base(w, bodyValue, colorValue, mirrorValue)
        {
            ++_count;
            this.Price = priceValue;
            this.SteeringWheel = SteeringWheelValue;
        

        }
     
        public override Car Clone()
        {
            ++_count;
            return (Car)this.MemberwiseClone();
        }
        public override void MoveCar()
        {
            Console.WriteLine("Car : MoveCar");
        }
        public override void SoundSystem()
        {
            Console.WriteLine("Car : SoundSystem ");
        }
        public override void Show()
        {
            
            Console.WriteLine($"--------------Car {_count}-------------------");
            base.Show();
            Console.WriteLine($"Price :  {Price}");

            Console.WriteLine($"SteeringWheel : {SteeringWheel}");
            this.SoundSystem();
            this.MoveCar();

           
        }
        public void EnergySystem(IAdpater adpater)
        {
            adpater.GetEnergySystem();
        }

    }
}
