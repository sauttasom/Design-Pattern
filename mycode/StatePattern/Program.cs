// See https://aka.ms/new-console-template for more information
using StatePattern;



Water water = new Water(new WaterSupply());

Console.WriteLine("It rained for a long time to canal water status : ");
water.Rain(string.Empty);


Console.WriteLine("Enter Chlorine to canal water status : ");
water.EnterChlorine();

Console.WriteLine("It rained for just a moment. Water status : ");
water.Rain("short");

Console.WriteLine("Enter Chlorine to canal water status : ");
water.EnterChlorine();



Console.WriteLine("releasing dirt into the river status : ");
water.Sewage();


Console.WriteLine("It rained for a long time to canal water status : ");
water.Rain("Long");
