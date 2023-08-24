using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Adapter.AdapterClass
{
    public class RefulStstemAdpter : IAdpater
    {
        private readonly RefulSystem _refulSystem;
        public  RefulStstemAdpter(RefulSystem refulSystem)
        {
            _refulSystem = refulSystem;
        }
        public void GetEnergySystem()
        {
            _refulSystem.GetRefulSystem();
        
        }
    }
    public class RefulSystem {
        public void GetRefulSystem()
        {
            Console.WriteLine("Car: RefulStstem");
        }
    }

}
