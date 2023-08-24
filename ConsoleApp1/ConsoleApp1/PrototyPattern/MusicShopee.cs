using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.PrototyPattern
{

    public abstract class MusicShopee
    {
        protected string? color { get; set; }
        protected double? price { get; set; }
        protected string? brand  { get; set; }

        public abstract MusicShopee Clone();
        public virtual void PrintOrder()
        {
            Console.WriteLine("========== MusicShopee =====");
            Console.WriteLine($"Total Price = {this.price} and Color = {color}" );
        }
        public MusicShopee() { }
        public MusicShopee(string colorValue , double priceValue , string typeValue ) {
            price = priceValue;
            color = colorValue;
            brand = typeValue;

        }

     


    }
   
}
