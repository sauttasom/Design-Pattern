using System;
using System.Collections.Generic;
using VisitorPattern.Element;

namespace VisitorPattern
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var life = new LifeInsurance()
            {
                Caimhistory = true
            };
            life.Caimhistory = true;

            var health = new HealthInsurance();
            health.Caimhistory = false;
            health.old = 27;

            var motor = new MotorInusrance();
            motor.ServiceLife = 6;


            var fireInsurance = new FireInsurance();
            fireInsurance.IsSTD = true;
            fireInsurance.BuildingYear = 5;

            var insuranceList = new List<Insurance>();
            insuranceList.Add(life);
            insuranceList.Add(health);
            insuranceList.Add(motor);
            insuranceList.Add(fireInsurance);


            Console.WriteLine("-----ValidateInsurance Visitor-----\n");
            var visitorValidate = new ValidateInsuranceVisitor();
            insuranceList.ForEach(x => x.Accept(visitorValidate));


            Console.WriteLine("\n");

            Console.WriteLine("-----Promotion Visitor-----\n");
           
            var promotionValidate = new PromotionVisitor();
            insuranceList.ForEach(x => x.Accept(promotionValidate));

        }
    }
}
