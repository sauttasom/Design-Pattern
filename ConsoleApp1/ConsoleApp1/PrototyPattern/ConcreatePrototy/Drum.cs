using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.PrototyPattern.ConcreatePrototy
{
    public class Drum : MusicShopee
    {

        public string DrumStick { get; set; }
        public string DrumHead { get; set; }
        public string BrakeDrum { get; set; }


        public override MusicShopee Clone()
        {
            return (MusicShopee)this.MemberwiseClone();
        }
        public Drum(string colorValue, double pricevalue, string brandvalue, string drumStrickValue, string drumheadValue, string brakeDrum)
           : base(colorValue, pricevalue, brandvalue)
        {
            DrumStick = drumStrickValue;
            DrumHead = drumheadValue;
            BrakeDrum = brakeDrum;

        }

        public override void PrintOrder()
        {

            Console.WriteLine($"Buy Guitar Total Summary : Price {base.price}  ");
            Console.WriteLine($"Brand : {base.brand} ");
            Console.WriteLine($"Drum Color : {base.color} ");
            Console.WriteLine($"Drum DrumHead : {this.DrumHead} ");
            Console.WriteLine($"Drum DrumStick: {this.DrumStick} ");
            Console.WriteLine($"Drum DrakeDrum  : {this.BrakeDrum} ");
        }

    }
}
