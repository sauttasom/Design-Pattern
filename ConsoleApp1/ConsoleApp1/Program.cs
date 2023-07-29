using Assignment.AbstractFactory;
using Assignment.AbstractFactory.Entity;
using Assignment.AbstractFactory.Factory;
using Assignment.BuilderPatterns;
using static Assignment.FactoryMethod.FactoryMethod2;

internal class Program
{
    static void Main(string[] args)
    {
        /// </summary>
        /// Factory Method Pattern
        /**
Console.WriteLine("Hello Factory Method Pattern");
//ShippingSystem boatTransport = new BoatTransport();
//Client(boatTransport);


//ShippingSystem truckTransport = new TruckTransport();
//Client(truckTransport);


//void Client(ShippingSystem shippingSystem)
//{
//    shippingSystem.Apply();
//}

SellingTea sellingTeaThai = new  MakingThaiTea();
Client(sellingTeaThai);


SellingTea sellingTeaGree = new MakingGreeTea();
Client(sellingTeaGree);


SellingTea sellingTeaLemon = new MakingLemonTea();
Client(sellingTeaLemon);

void Client(SellingTea sellingTea)
{
            sellingTea.Order();
}*/

        /// </summary>
        /// Factory Method Pattern
        /**
         
           
            Client clientDarkRoast = new Client(new DarkRoastFactory());
            clientDarkRoast.makeCoffee();

            Client clientMediumRoast = new Client(new MediumFactory());
            clientMediumRoast.makeCoffee();

            Client clientLightRoast = new Client(new LightFactory());
            clientLightRoast.makeCoffee();
       */




        Console.WriteLine("--------- Create : Yacht  ----------");
        var yecht = new YachtBuilder();
        Director director = new Director();
        director.makeYacht(yecht);
        Boat boat1 = yecht.GetYacht();
        boat1.Show();


        Console.WriteLine("--------- Create : FishingBoat ----------");
        var boathfish = new FishingBoatBuilder();
        Director director2 = new Director();
        director2.makeFishingBoat(boathfish);
        Boat boat2 =  boathfish.GetFishingBoat();
        boat2.Show();


    }

}