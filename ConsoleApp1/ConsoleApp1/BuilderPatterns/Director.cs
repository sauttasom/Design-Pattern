using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.BuilderPatterns
{
    public class Director
    {
        
        public void makeYacht(IBuilder builder)
        {
            builder.buildFishFishingEquipment(false);
            builder.buildRoomService(true);
            builder.buildRudder();
            builder.buildBilge();
            builder.buildStern();
            builder.buildGunnel();
        }
        public void makeFishingBoat(IBuilder builder)
        {

            builder.buildFishFishingEquipment(true);
            builder.buildRoomService(false);
            builder.buildRudder();
            builder.buildBilge();
            builder.buildStern();
            builder.buildGunnel();
        }
    }
}
