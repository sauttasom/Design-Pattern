using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern.Service
{
    public class PaymentService
    {
        public string paymentMethod { get; set; }
        public bool paymentState { get; set; }


        public string GetTransaction()
        {
            string tar = $"-----------Transaction----------------\n " +
                $"Payment Method : {paymentMethod}\n" +
                $"PaymentDate : {DateTime.Now}\n" +
                $"PaymentName  : Mr. Tony Woodsome\n" +
                "Payment Status: " + (paymentState ? "Success" : "Fail") + "\n";
            return tar;
        }
    }
}
