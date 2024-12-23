using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern.Service
{
    public class OrderDetail
    {

        public string ItemDetail(Product product)
        {
            string detail = $"========Product Detail========\n" +
                $"Product Name : {product.Name} \nProduct Price :{product.Price}";

            return detail ;
        }
        public string OrderPaymentStatus(PaymentService paymentService)
        {
            if (!paymentService.paymentState)
            {
                return "Item Buy Fail";
            }

            return paymentService.GetTransaction();
        }
        public string OrderShipping(ShippingService shipping, PaymentService paymentService)
        {
            if (!paymentService.paymentState)
            {
                return "Item not yet Payment .Please Pay Money ";
            }
            var detailShip = "Transport By " + shipping.GetShippingSystem() + "\n" +
                            "Transport Cost : " + shipping._costShipping + "\n" +
                            "Transport Status : IN TRANSIT";
            return detailShip;
           
        }
    }
}
