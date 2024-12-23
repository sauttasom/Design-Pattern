using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.FactoryMethod
{
    internal class FactoryMethod2
    {
        public abstract class TeaMakingStep
        {
            public abstract void BoilWater();
            public abstract void PourWarterToTea();
            public abstract void PourTeaToGlass();

        }
        public class LemonTea : TeaMakingStep
        {
            public override void BoilWater()
            {
                Console.WriteLine("LemonTea : BoilWater");
            }

            public override void PourTeaToGlass()
            {
                Console.WriteLine("LemonTea : PourTeaToGlass");
            }

            public override void PourWarterToTea()
            {
                Console.WriteLine("LemonTea : PourWarterToTea");
            }
        }
        public class GreenTea : TeaMakingStep
        {
            public override void BoilWater()
            {
                Console.WriteLine("GreenTea : BoilWater");
            }

            public override void PourTeaToGlass()
            {
                Console.WriteLine("GreenTea : PourTeaToGlass");
            }

            public override void PourWarterToTea()
            {
                Console.WriteLine("GreenTea : PourWarterToTea");
            }
        }
        public class ThiaTea : TeaMakingStep
        {
            public override void BoilWater()
            {
                Console.WriteLine("ThiaTea : BoilWater");
            }

            public override void PourTeaToGlass()
            {
                Console.WriteLine("ThiaTea : PourTeaToGlass");
            }

            public override void PourWarterToTea()
            {
                Console.WriteLine("ThiaTea : PourWarterToTea");
            }
        }

        public abstract class SellingTea
        {

            public abstract TeaMakingStep MakeTea();
            public void Order()
            {
                var doingTea = MakeTea();
                Console.WriteLine("------------Tea Process ----------");
                doingTea.BoilWater();
                doingTea.PourWarterToTea();
                doingTea.PourTeaToGlass();
                Console.WriteLine("------------End Process ----------");



            }
        }
        public class MakingThaiTea : SellingTea
        {
            public override TeaMakingStep MakeTea()
            {
                return new ThiaTea();
            }

        }
        public class MakingGreeTea : SellingTea
        {
            public override TeaMakingStep MakeTea()
            {
                return new GreenTea();
            }

        }
        public class MakingLemonTea : SellingTea
        {
            public override TeaMakingStep MakeTea()
            {
                return new LemonTea();
            }

        }
    }
}
