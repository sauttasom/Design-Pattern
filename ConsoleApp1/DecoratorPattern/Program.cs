using DecoratorPattern;

Beverage espresso = new Espresso();
Console.WriteLine("Coffee Detail: " + espresso.GetDetail());
Console.WriteLine("Cost: " + espresso.GetCost());

var addMilk = new Milk(espresso);
Console.WriteLine("Add Milk Detail: " + addMilk.GetDetail());
Console.WriteLine("Add Milk Cost : " + addMilk.GetCost());



var addMilkandAddSugar = new Sugar(addMilk);
Console.WriteLine("Add Sugar Detail: " + addMilkandAddSugar.GetDetail());
Console.WriteLine("Add Sugar Cost : " + addMilkandAddSugar.GetCost());



var addMilkandAddSugarAndCaramel = new Caramel(addMilkandAddSugar);
Console.WriteLine("Add Caramel Detail: " + addMilkandAddSugarAndCaramel.GetDetail());
Console.WriteLine("Add Caramel Cost : " + addMilkandAddSugarAndCaramel.GetCost());



Console.WriteLine("----------------Cappuccino----------------");

Beverage cappuccino = new Cappuccino();
Console.WriteLine("Coffee Detail: " + cappuccino.GetDetail());
Console.WriteLine("Cost: " + cappuccino.GetCost());

var cappuccinoaddMilk = new Milk(cappuccino);
Console.WriteLine("Add Milk Detail: " + cappuccinoaddMilk.GetDetail());
Console.WriteLine("Add Milk Cost : " + cappuccinoaddMilk.GetCost());



var cappuccinoaddMilkandAddSugar = new Sugar(cappuccinoaddMilk);
Console.WriteLine("Add Sugar Detail: " + cappuccinoaddMilkandAddSugar.GetDetail());
Console.WriteLine("Add Sugar Cost : " + cappuccinoaddMilkandAddSugar.GetCost());



var cappuccinoaddMilkandAddSugarAndCaramel = new Caramel(cappuccinoaddMilkandAddSugar);
Console.WriteLine("Add Caramel Detail: " + cappuccinoaddMilkandAddSugarAndCaramel.GetDetail());
Console.WriteLine("Add Caramel Cost : " + cappuccinoaddMilkandAddSugarAndCaramel.GetCost());
