using Facade_Pattern.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    public class OrderFacade
    {
        private Product _product { get; set; }
        private List<Product> _productsList = new List<Product>();
        private PaymentService _paymentService;

        private ShippingService _shippingService;
        private OrderDetail _orderStatus;
        public OrderFacade()
        {
            _orderStatus = new OrderDetail();
        }
        public void AddCart(Product product)
        {

            _productsList.Add(new Product() { Name = product.Name , Price = product.Price});
        }
        public void ViewCart()
        {
            foreach (Product product in _productsList)
            {

                Console.WriteLine(_orderStatus.ItemDetail(product));
            }
        }
        public void BuyProduct(Product product, PaymentService payment, bool fastTrans)
        {
            _product = new Product();
            _product.Name = product.Name;
            _product.Price = product.Price;


            _shippingService = new ShippingService();
            _shippingService.shippingSystem = "Kerry";
            if (fastTrans)
            {
                _shippingService.FastShipping();
            }


            _paymentService = new PaymentService();
            _paymentService.paymentMethod = payment.paymentMethod;
            _paymentService.paymentState = payment != null ? true : false;

            Console.WriteLine(_orderStatus.ItemDetail(_product));
            Console.WriteLine(_orderStatus.OrderShipping(_shippingService, _paymentService));
            Console.WriteLine(_orderStatus.OrderPaymentStatus(_paymentService));



        }
    }
}
