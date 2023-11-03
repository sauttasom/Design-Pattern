using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StrategyPattern.ConcreteStrategy
{
    public class CashPayment : IPaymentStrategy
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Paid {amount:C} with CashPaymennt System.");
        }
    }
    public class CreditCardPayment : IPaymentStrategy
    {
        private string cardNumber;
        public CreditCardPayment(string cardNumber)
        {
            this.cardNumber = cardNumber;
        }
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Paid {amount:C} with credit card {cardNumber}");
        }
    }
    public class AppWalletPayment : IPaymentStrategy
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Paid {amount:C} with AppWalletPayment");
        }
    }
    public class MoblieBankingPayment : IPaymentStrategy
    {
        private string _bankName;
        public MoblieBankingPayment(string bankName)
        {
            _bankName = bankName;
        }
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Paid {amount:C} with MoblieBanking Payment In Bank Name : {_bankName}");
        }
    }
}
