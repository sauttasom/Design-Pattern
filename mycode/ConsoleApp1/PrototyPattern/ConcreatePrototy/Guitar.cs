using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.PrototyPattern.ConcreatePrototy
{
    public class Guitar : MusicShopee
    {
        private MusicShopee _musicShopee;
        public string guitarString { get; set; }
        public string picksUp { get; set; }
        public string fret { get; set; }

      
         
        public Guitar(string colorValue, double pricevalue, string typeValue, string StringValue, string picupValue, string fretValue)
            : base(colorValue, pricevalue, typeValue)
        {
            guitarString = StringValue;
            picksUp = picupValue;
            fret = fretValue;
            
        }
    
        public override void PrintOrder()
        {
            
            Console.WriteLine($"Buy Guitar Total Summary : Price {base.price}  ");
            Console.WriteLine($"Brand : {base.brand} ");
            Console.WriteLine($"Guitar Color : {base.color} ");
            Console.WriteLine($"Guitar Staring : {this.guitarString} ");
            Console.WriteLine($"Guitar PicksUp  : {this.picksUp} ");
            Console.WriteLine($"Guitar Fret  : {this.fret} ");
        }
        public override MusicShopee Clone()
        {
            // return new Guitar( this.guitarString, this.picksUp,this.fret);
            return (Guitar)this.MemberwiseClone();
        }
    }

}
