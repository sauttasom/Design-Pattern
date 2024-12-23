// See https://aka.ms/new-console-template for more information
using Facade_Pattern;
using Facade_Pattern.Service;

Product product = new Product
{
    Name = "Iphone14 Pro Max 256GB",
    Price = 60000
};
var payment = new PaymentService { paymentMethod = "digital wallets" };

OrderFacade orderFacade = new OrderFacade();
orderFacade.BuyProduct(product, payment, false);


Product product2 = new Product
{
    Name = "Samsung galaxy S22",
    Price = 56770
};
orderFacade.BuyProduct(product2, payment, false);


for (int i = 1;i < 5;i++)
{
    Product product3 = new Product
    {
        Name = "Samsung galaxy Ultar",
        Price = 25000 * i ,
    };
    orderFacade.AddCart(product3);
}
orderFacade.ViewCart();