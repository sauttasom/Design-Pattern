using DecoratorPattern;

Coffee espresso = new Espresso();


Console.WriteLine("Coffee Detail: " + espresso.GetDetail());


Coffee Latte = new Milk(espresso);
Coffee mocha = new Chocolate(Latte);
Coffee cappuccino = new WhippedCream(mocha);
Coffee caramelMacchiato = new Caramel(cappuccino);


Console.WriteLine("Add Milk Detail: " + Latte.GetDetail());
Console.WriteLine("Add Chocolate  : " + mocha.GetDetail());
Console.WriteLine("Add WhippedCream  : " + cappuccino.GetDetail());
Console.WriteLine("Add Caramel  : " + caramelMacchiato.GetDetail());



Console.WriteLine("Total Coffee Cost  : " + caramelMacchiato.GetCost() + "/Baht");


