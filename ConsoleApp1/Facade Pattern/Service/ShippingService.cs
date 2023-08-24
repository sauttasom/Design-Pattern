using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern.Service
{
    public class ShippingService
    {
        public int _costShipping { get; set; }
        public string shippingSystem { get; set; }
        public ShippingService() {
            _costShipping = 25;
        }
      
        public string GetShippingSystem()
        {
            return shippingSystem;
        }
        public void FastShipping() {
             this._costShipping  += 50;
        }
    }
}
