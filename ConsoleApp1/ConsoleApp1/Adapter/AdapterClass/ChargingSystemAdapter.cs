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
        public void GetEnergySystem()
        {
            _chargingSystem.GetChargingSystem();
        }
    }

    public class ChargingSystem {

        public void GetChargingSystem()
        {
            Console.WriteLine("Car: ChargingSystem");
        }

    }

}
