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
        public double GetEnergySystem()
        {
        
            return  _refulSystem.GetRefulSystem() * 1000 ;
        }
    }

    public class RefulSystem {

        private double _RefulLiter { get; set; }
        public RefulSystem(int unit)
        {
            _RefulLiter = unit;
        }

        public RefulSystem()
        {
            _RefulLiter = 1;
        }
     
        public double  GetRefulSystem()
        {
            return _RefulLiter;
        }
    }

}
