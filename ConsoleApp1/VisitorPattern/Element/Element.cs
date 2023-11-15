using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern.Element
{
    public interface Insurance
    {
        public void Accept(IVisitor visitor);

    }
    public class MotorInusrance : Insurance
    {
        public int ServiceLife { get; set; }
        public double InsurancePremium { get; set; }
        public MotorInusrance()
        {
            InsurancePremium = 3000;
        }
        public void Accept(IVisitor visitor)
        {
            visitor.VisitMotorInsurnce(this);
        }
    }
    public class LifeInsurance : Insurance
    {
        public bool Caimhistory { get; set; }
        public double InsurancePremium { get; set; }
        public LifeInsurance()
        {
            InsurancePremium = 1000;
        }
        public void Accept(IVisitor visitor)
        {
            visitor.VisitLifeInsurnce(this);
        }
    }
    public class HealthInsurance : Insurance
    {

        public bool Caimhistory { get; set; }
        public int old { get; set; }
        public double InsurancePremium { get; set; }

        public HealthInsurance()
        {
            InsurancePremium = 2000;
        }
        public void Accept(IVisitor visitor)
        {
            visitor.VisitHealtInsurance(this);
        }
    }
    public class FireInsurance : Insurance
    {
        public bool IsSTD { get; set; }
        public int BuildingYear { get; set; }
        public double InsurancePremium { get; set; }
    

        public FireInsurance()
        {   
            InsurancePremium = 5000;
        }
        public void Accept(IVisitor visitor)
        {
            visitor.VisitFireInsurance(this);
        }
    }
}
