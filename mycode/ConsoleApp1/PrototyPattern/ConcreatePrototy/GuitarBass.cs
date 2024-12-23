using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.PrototyPattern.ConcreatePrototy
{
    public class GuitarBass : MusicShopee
    {
        public string bassString { get; set; }
        public string pickups { get; set; }
        public string tuning { get; set; }

        public GuitarBass(string guitarString, string picksUp, string fret)
        {
            this.bassString = guitarString;
            this.pickups = picksUp;
            this.tuning = fret;
        }

        public GuitarBass(string colorValue, double pricevalue, string typeValue, string StringValue, string picupValue, string fretValue)
            : base(colorValue, pricevalue, typeValue)
        {
            bassString = StringValue;
            pickups = picupValue;
            tuning = fretValue;
        }
        public override void PrintOrder()
        {

            Console.WriteLine($"Buy GuitarBass Total Summary : Price {base.price}");
            Console.WriteLine($"Brand : {base.brand} ");
            Console.WriteLine($"Guitar Color : {base.color} ");
            Console.WriteLine($"GuitarBass String  :  {this.bassString} ");
            Console.WriteLine($"GuitarBass pickups :  {this.pickups} ");
            Console.WriteLine($"GuitarBass  tuning :  {this.tuning} ");
        }
        public override MusicShopee Clone()
        {
            return (GuitarBass)this.MemberwiseClone();
        }
    }
}
