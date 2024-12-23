using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class WaterSupply : State
    {

        public WaterSupply()
        {
            base.stateName = "Water Supply";
        }
        public override void Rain(string isLongtime)
        {
            base.water.ChangeState(new WaterSupply());
        }
        public override void EnterChlorine() 
        {
            base.water.ChangeState(new DrinkingWater());
        }
        public override void Sewage() {
            base.water.ChangeState(new SewageWater());
        }
    }
    public class SewageWater : State
    {
      
        public SewageWater() {
            base.stateName = "Sewage Water";
        }
        public override void Rain(string isLongtime)
        {
            if (isLongtime == "Long")
            {
                base.water.ChangeState(new WaterSupply());
            }

        }
        public override void EnterChlorine()
        {
            base.water.ChangeState(new WaterSupply());
        }
        public override void Sewage()
        {
            base.water.ChangeState(new SewageWater());
        }
    }
    public class DrinkingWater : State
    {

        public DrinkingWater()
        {
            base.stateName = "Drinking Water";
        }
        public override void Rain(string isLongtime)
        {
            if(isLongtime == "Long")
            {
                base.water.ChangeState(new WaterSupply());
            }
            else
            {
                base.water.ChangeState(new SewageWater());
            }
          
        }
        public override void EnterChlorine()
        {
            base.water.ChangeState(new DrinkingWater());
        }
        public override void Sewage()
        {
            base.water.ChangeState(new SewageWater());
        }
    }
   
}
