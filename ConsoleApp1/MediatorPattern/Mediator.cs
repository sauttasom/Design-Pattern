using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MediatorPattern
{
    public interface IMediator
    {
        public void Notify(EarlyWarningCollegues sender, string msg);
        public void ViewReport(EarlyWarningCollegues sender);
    }

    public class AppMediator : IMediator
    {
        public IList<EarlyWarningCollegues> EarlyWarningColleguesList
        {
            get; private set;
        }
        public AppMediator(List<EarlyWarningCollegues> collegues)
        {
            collegues.ForEach(x => x.SetMediator(this));
            EarlyWarningColleguesList = collegues;
        }

        public void ViewReport(EarlyWarningCollegues sender)
        {
            foreach (var dep in EarlyWarningColleguesList)
            {
                dep.AnalysisData();
                Console.WriteLine("-----Please wait-----");
                dep.ShowReport();
            }
        }

        public void Notify(EarlyWarningCollegues sender, string msg)
        {
            foreach (var receiver in EarlyWarningColleguesList)
            {
                var departmentName = sender.GetDepartmentName();

                if (receiver != sender)
                {

                    receiver.ReceiveMsg(msg, departmentName);
                    receiver.KeepData(msg);

                }
             
            }
        }
    }


}
