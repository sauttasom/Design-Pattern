using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public abstract class HealthTracker
    {
        public void Track()
        {
            RecordActivity();
            RecordFood();
            DisplaySummary();
        }

        protected abstract void RecordActivity();
        protected abstract void RecordFood();

        protected void DisplaySummary()
        {
            Console.WriteLine("-----------summary--------------");
            Console.WriteLine(" Exercise more : very healthy ");
            Console.WriteLine("----------- end summary--------------");
  
        }
    }
    class RunningTracker : HealthTracker
    {
        protected override void RecordActivity()
        {
            Console.WriteLine("Tracking running activity");
            CalculateRunningDistance();
        }

        protected override void RecordFood()
        {
            Console.WriteLine("Tracking food intake after running");
        }

        private void CalculateRunningDistance()
        {
            Console.WriteLine("Calculating running distance 7.3 KM");
            
        }
    }
    class YogaTracker : HealthTracker
    {
        protected override void RecordActivity()
        {
            Console.WriteLine("Tracking yoga activity");
        }

        protected override void RecordFood()
        {
            Console.WriteLine("Tracking food intake after yoga");
        }
    }

}
