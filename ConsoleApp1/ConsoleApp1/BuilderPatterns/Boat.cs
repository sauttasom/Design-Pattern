using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.BuilderPatterns
{
    public class Boat
    {

        public bool RoomService { get; set; }
        public bool FishingEquipment { get; set; }
        public bool DrainPump { get; set; }
        public bool weapon { get; set; }


        public void setBilge()
        {
            Console.WriteLine("BoatBuilder : buildBody");
        }
        public void setBody()
        {
            Console.WriteLine("BoatBuilder : buildBody");
        }

        public void setGunnel()
        {
            Console.WriteLine("BoatBuilder : builGunnel");
        }

        public void setRudder()
        {
            Console.WriteLine("BoatBuilder : builRudder");
        }

        public void setStern()
        {
            Console.WriteLine("BoatBuilder : builStern");
        }
        public void setDrainPump()
        {
            Console.WriteLine("BoatBuilder : DrainPump");
        }


        public void Show()
        {

            if (RoomService)
            {
                Console.WriteLine("Boat Build The RoomService");
            }
            if (FishingEquipment)
            {
                Console.WriteLine("Boat Build The FishingEquipment");
            }
            if (DrainPump)
            {
                Console.WriteLine("Boat Build The DrainPump");
            }
            if (weapon)
            {
                Console.WriteLine("Boat Build The Weapon");
            }
        }
    }
}
