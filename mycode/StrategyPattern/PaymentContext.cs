using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class PaymentContext
    {
        private IPaymentStrategy _paymentStrategy;

        public PaymentContext(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }
        public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
        {
            this._paymentStrategy = paymentStrategy;
        }
        public void ProcessPayment(double amount)
        {
            _paymentStrategy.ProcessPayment(amount);
        }
    }
}
