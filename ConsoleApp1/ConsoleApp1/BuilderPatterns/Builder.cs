using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.BuilderPatterns
{
    // Interface
    public interface IBuilder
    {
        public void resetBoat();
        public void buildBody();
        public void buildBilge();
        public void buildGunnel();
        public void buildStern();
        public void buildRudder();
        public void buildFishFishingEquipment(bool fishing);
        public void buildRoomService(bool value);
    }

    public class FishingBoatBuilder : IBuilder
    {
        private  Boat _boat = new Boat();
        public void buildFishFishingEquipment(bool fishing)
        {

            _boat.FishingEquipment = fishing;

        }
        public void buildRoomService(bool value)
        {
            _boat.RoomService = value;
        }
        public void buildBilge()
        {
            _boat.setBilge();
        }

        public void buildBody()
        {
            _boat.setBody();
        }

        public void buildGunnel()
        {
            _boat.setGunnel();
        }

        public void buildRudder()
        {
            _boat.setRudder();
        }

        public void buildStern()
        {
            _boat.setStern();
        }

        public void resetBoat()
        {
            _boat = new Boat();

        }
        public Boat GetFishingBoat()
        {
            var boat = _boat;
            this.resetBoat();
            return boat;
        }

    }

    public class YachtBuilder : IBuilder
    {
        private Boat _boat = new Boat();


        public void buildFishFishingEquipment(bool fishing)
        {
            _boat.FishingEquipment = fishing;

        }
        public void buildRoomService(bool isRoom)
        {

            _boat.RoomService = isRoom;
        }
        public void buildBilge()
        {

            _boat.setBilge();
        }

        public void buildBody()
        {
            _boat.setBody();
        }

        public void buildGunnel()
        {
            _boat.setGunnel();
        }

        public void buildRudder()
        {
            _boat.setRudder();
        }

        public void buildStern()
        {
            _boat.setStern();
        }

        public void resetBoat()
        {
            _boat = new Boat();
        }

        public Boat GetYacht()
        {
            var boat = _boat;
            this.resetBoat();
            return boat;
        }
      
    }

    public class Boat 
    {

        public bool RoomService { get; set; }
        public bool FishingEquipment { get; set; }
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
        public void Show()
        {
            
            if (RoomService)
            {
                Console.WriteLine("Create : Yacht Builder Success");
            }
            else
            {
                Console.WriteLine($"Create : Boat Fishing Builder Success");
            }
          

        }



    }


}
