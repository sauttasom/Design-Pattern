using Assignment.AbstractFactory;
using Assignment.AbstractFactory.Entity;
using Assignment.AbstractFactory.Factory;
using Assignment.Adapter.AdapterClass;
using Assignment.Adapter.TargetClass;
using Assignment.BuilderPatterns;
using Assignment.PrototyPattern;
using Assignment.PrototyPattern.ConcreatePrototy;
using Assignment.SingletonPattern;
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

        /// </summary>
        /// Building  Pattern

        Director director = new Director();

        
        SwordBuilder swordBuilder = new SwordBuilder();
        ToySwordBuilder toyBuilder = new ToySwordBuilder();

        director.MakeKatana(swordBuilder);
        swordBuilder.GetSword().Show();


        director.MakeKatana(toyBuilder);
        toyBuilder.GetSword().Show();

        director.MakeKrabi(swordBuilder);
        swordBuilder.GetSword().Show();

        director.MakeKrabi(toyBuilder);
        toyBuilder.GetSword().Show();
        

        /// </summary>
        /// Prototy  Pattern
        /* 
            Console.WriteLine("--------- Prototy  Pattern ----------");
            OrderMusic orderMusic = new OrderMusic();
            orderMusic.Checkstock();

            MusicShopee buyGuitar = orderMusic.buyProduct(new Guitar("Red", 15000, "YAMAHA", "gibson", "picksUp", "fretGibson"));
            buyGuitar.PrintOrder();
             var gutar2 = buyGuitar.Clone();
             Console.WriteLine(gutar2);



            MusicShopee buyBassGuitar = orderMusic.buyProduct(new GuitarBass("Blue", 350000, "Gibson", "gibson", "picksUp", "fretGibson"));
            buyBassGuitar.PrintOrder();


            MusicShopee buyDrum = orderMusic.buyProduct(new Drum("Yellow", 500000, "Pearl", "Pearl DrumStrick", "Pearl DrumHead", "Pearl BarkDurm"));
            buyDrum.PrintOrder();


            orderMusic.Checkstock();
        */

        /// </summary>
        /// Singleton  Pattern
        /*
        var context = Mydatabase.GetDbContext();
   
        var data = context.Executequery("select * from City");
        foreach (var item in data)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("-------------Context2--------------");
        var context2 = Mydatabase.GetDbContext();
        var data2 = context2.Executequery("select * from City");
        foreach (var item in data)
        {
            Console.WriteLine(item);
        }
        context2.Close();
        */

        /// <summary>
        /// Adapter Pattern
        /// </summary>
        /// 
        
        Car car = new Car("Wheel", "BodyCar", "Color", "Mirror", 1100000, "SteeringWheel1",600);
        //var reful = new RefulSystem(5);
        var refulAdapter = new RefulStstemAdpter(new RefulSystem(5));

        //var charging = new ChargingSystem(100);
       
        car.SetEnergySystem(refulAdapter);
        car.Show();
  
        var car2 = car.Clone();
        car2.Price = 200000000;
        car2.SteeringWheel = "SteeringWheelCar2";
        var chargingAdapter = new ChargingSystemAdapter(new ChargingSystem());
        car2.SetEnergySystem(chargingAdapter);
        car2.Show();
        

        Console.ReadLine();
    }

}