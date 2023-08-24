using BridgePattern.Implementor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Abstraction
{
    public  class SoftDrinks
    {
        private ISugar _isugar;

        
        public SoftDrinks(ISugar isugar)
        {
            _isugar = isugar;
        }
        public virtual void BuyItem() { }

        public virtual void DisplayDetail() {
            
            Console.WriteLine($"Detail Sugar : {_isugar.GetDetail()}");
            Console.WriteLine($"Name :{_isugar.GetSugarName()}");
            Console.WriteLine($"Type :{_isugar.GetType()}");
            Console.WriteLine($"Process : {_isugar.GetProcess()}");
            Console.WriteLine($"Detail  : {_isugar.GetDetail()}");
        }

    }

    public class Cola : SoftDrinks  
    {
        public Cola(ISugar isugar) :base(isugar) {
            Console.WriteLine("==========Create Cola SoftDrinks===============");
        }

        public override void BuyItem()
        {
            Console.WriteLine("buy Cola : Pirce 15 Baht");
        }

        public override void DisplayDetail()
        {
              base.DisplayDetail();
        }
    }

    public class Spirit: SoftDrinks
    {
        public Spirit(ISugar isugar) : base(isugar) {
            Console.WriteLine("==========Create Spirit SoftDrinks===============");
        }

        public override void BuyItem()
        {
            Console.WriteLine("buy Spirit : Pirce 25 Baht");
        }
        public override void DisplayDetail()
        {
            base.DisplayDetail();
        }
    }
    public class Fanta : SoftDrinks
    {
        public Fanta(ISugar isugar) : base(isugar) {
            Console.WriteLine("==========Create Fanta SoftDrinks===============");
        }
        public override void BuyItem()
        {
            Console.WriteLine("buy Fanta : Pirce 20 Baht");
        }
        public override void DisplayDetail()
        {
            base.DisplayDetail();
        }
    }
}
