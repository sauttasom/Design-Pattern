using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Element;

namespace VisitorPattern
{
    public interface IVisitor
    {
        public void VisitMotorInsurnce(MotorInusrance motorInusrance);
        public void VisitLifeInsurnce(LifeInsurance lifeInsurance);
        public void VisitHealtInsurance(HealthInsurance  healthInsurance);

        public void VisitFireInsurance(FireInsurance fireInsurance);
    }
    public class ValidateInsuranceVisitor : IVisitor
    {
        public void VisitMotorInsurnce(MotorInusrance motorInusrance)
        {
            Console.WriteLine("-------MotorInusrance-------");
            var newPremium = motorInusrance.InsurancePremium;
            if (motorInusrance.ServiceLife > 5)
            {
                newPremium = motorInusrance.InsurancePremium *50;
                Console.WriteLine($"MotorInusrance Service Life > 5 year then InsurancePremium +50%");
            }
            
            Console.WriteLine($"MotorInusrance New InsurancePremium   :{newPremium} / Year");

        }
        public void VisitLifeInsurnce(LifeInsurance lifeInsurance)
        {
            Console.WriteLine("-------LifeInsurance-------");
            if (!lifeInsurance.Caimhistory)
            {
             
                Console.WriteLine($"Able to  get insurance  New LifeInsurance  :{lifeInsurance.InsurancePremium} / Year");

            }
            else
            {
                Console.WriteLine($"Sorry!!  UnAble get insurance Life Insurance ");
                lifeInsurance.InsurancePremium = 0;
            }
            

        }
        public void VisitHealtInsurance(HealthInsurance healthInsurance)
        {
            Console.WriteLine("-------HealthInsurance-------");
            if (healthInsurance.old > 60)
            {
                healthInsurance.InsurancePremium = 0;
                Console.WriteLine($"Unable to get healt insurance ");
            }
            else
            {
                Console.WriteLine($"Able to get healt InsurancePremiums :  {healthInsurance.InsurancePremium} / Year");
            }

       


        }

        public void VisitFireInsurance(FireInsurance fireInsurance)
        {
            Console.WriteLine("-------FireInsurance-------");
            if (!fireInsurance.IsSTD)
            {
                Console.WriteLine("Unable to get fire Insurance");
                fireInsurance.InsurancePremium = 0;
            }
            else
            {
                Console.WriteLine("Able to get fire insurance pay 5000/year ");
                fireInsurance.InsurancePremium = 5000;
            }
        }
    }
    public class PromotionVisitor : IVisitor
    {
        public void VisitMotorInsurnce(MotorInusrance motorInusrance)
        {

            if (motorInusrance.InsurancePremium == 0)
                return;

            Console.WriteLine("-------MotorInusrance-------");
            var newPremium = motorInusrance.InsurancePremium;
            if (motorInusrance.ServiceLife <= 3)
            {
                newPremium = newPremium - (motorInusrance.InsurancePremium * 20) /100 ;
                Console.WriteLine($"FREE!! Change engine oil and discount InsurancePremium -20%");
                Console.WriteLine($"MotorInusrance New InsurancePremium   :{newPremium} / Year");
                motorInusrance.InsurancePremium = newPremium;
            }
            else if (motorInusrance.ServiceLife <= 5)
            {
                Console.WriteLine($"FREE!! Change engine oil");
            }
            else
            {
                Console.WriteLine($"No Promotion");
            }


        }
        public void VisitLifeInsurnce(LifeInsurance lifeInsurance)
        {

            if (lifeInsurance.InsurancePremium == 0)
                return;

            Console.WriteLine("-------LifeInsurance-------");
            if (!lifeInsurance.Caimhistory)
            {
                Console.WriteLine($"Discount!! InsurancePremium -30%");
                var newPremium = lifeInsurance.InsurancePremium - (lifeInsurance.InsurancePremium * 30) / 100;
                lifeInsurance.InsurancePremium = newPremium;
                Console.WriteLine($"New insurance premiums  :{newPremium} / Year");

            }
            else
            {
                Console.WriteLine($"Receive a gift more ");
            }


        }
        public void VisitHealtInsurance(HealthInsurance healthInsurance)
        {

            if (healthInsurance.InsurancePremium == 0)
                return;

            Console.WriteLine("-------HealthInsurance-------");
            if (healthInsurance.old <= 25 && !healthInsurance.Caimhistory)
            {
                Console.WriteLine($"Discount!! InsurancePremium -50% and Receive a gift more ");
                var newPremium = healthInsurance.InsurancePremium - (healthInsurance.InsurancePremium * 50) / 100;
                healthInsurance.InsurancePremium = newPremium;
             
            }
            else if (!healthInsurance.Caimhistory)
            {
                Console.WriteLine($"Receive a gift more ");
            }
            else
            {
                Console.WriteLine($"No Promotion");
            }




        }

        public void VisitFireInsurance(FireInsurance fireInsurance)
        {
            if (fireInsurance.InsurancePremium == 0)
                return;


            Console.WriteLine("-------FireInsurance-------");
            if (fireInsurance.IsSTD && fireInsurance.BuildingYear <= 10)
            {
                Console.WriteLine($"FREE insurance 2 year and Receive a gift more ");
            }
            else 
            {
                Console.WriteLine($"Receive a gift more ");
            }
        }
    }
}
