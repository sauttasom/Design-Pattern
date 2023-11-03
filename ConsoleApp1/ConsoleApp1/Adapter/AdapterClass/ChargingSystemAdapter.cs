using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Adapter.AdapterClass
{
    public class ChargingSystemAdapter : IAdpater
    {
        private  ChargingSystem _chargingSystem;
        

        public ChargingSystemAdapter(ChargingSystem chargingSystem)
        {
            _chargingSystem = chargingSystem;
        }
        public double GetEnergySystem()
        {
           return  _chargingSystem.GetChargingSystem() / 100;
        }
    }

    public class ChargingSystem {
        private double _Percent { get; set; }
        public ChargingSystem()
        {
            _Percent = 100;
        }
        public  ChargingSystem(double unit)
        {
            _Percent = unit;    
        }
        public double GetChargingSystem()
        {
            
            return _Percent;
        }

    }

}
