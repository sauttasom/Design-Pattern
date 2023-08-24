using Assignment.PrototyPattern.ConcreatePrototy;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.PrototyPattern
{
    public class OrderMusic
    {
        public Hashtable itemCount = new Hashtable() {
            {"Guitar" ,50 },
            {"GuitarBass" , 40},
            {"Drum" , 10}
        };

        public void Checkstock()
        {

            Console.WriteLine("Check Product ");

            Console.WriteLine("---------Guitar---------");
            Console.WriteLine($"Drum have  Product : {itemCount["Guitar"]} items");
            Console.WriteLine("---------GuitarBass---------");
            Console.WriteLine($"Drum have  Product : {itemCount["GuitarBass"]} items");
            Console.WriteLine("---------Drum---------");
            Console.WriteLine($"Drum have  Product : {itemCount["Drum"]} items");
            Console.WriteLine("------------------");

        }
        public MusicShopee buyProduct(MusicShopee musicShopee)
        {
            var item = musicShopee;
            var type = item.GetType().Name;
            for (int i = 0; i < itemCount.Count;i++)
            {
                if (itemCount.ContainsKey(musicShopee.GetType().Name))
                {
                    itemCount[type] = (int) itemCount[type] - 1;
                }
            }

            return musicShopee.Clone();
        }

    }

}