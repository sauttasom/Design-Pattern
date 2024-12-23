
using StrategyPattern;
using StrategyPattern.ConcreteStrategy;

var paymentContext = new PaymentContext(new CashPayment());
paymentContext.ProcessPayment(100.0);


//change Payment Type to CreditCardPayment
paymentContext.SetPaymentStrategy(new CreditCardPayment("1234-5678-1234-5678"));
paymentContext.ProcessPayment(200);

//change Payment Type to AppWalletPayment
paymentContext.SetPaymentStrategy(new AppWalletPayment());
paymentContext.ProcessPayment(300);

//change Payment Type to AppWalletPayment
paymentContext.SetPaymentStrategy(new MoblieBankingPayment("SCB"));
paymentContext.ProcessPayment(400);