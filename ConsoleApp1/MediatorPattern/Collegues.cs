using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MediatorPattern
{
    public abstract class EarlyWarningCollegues
    {
        public IMediator _mediator { get; private set; }
        protected string departmentName { get; set; }

        public abstract void ReceiveMsg(string msg, string departmentName);
        public virtual void KeepData(string data) { }
        public virtual void AnalysisData() { }
        public virtual void ShowReport() { }
        public void SetMediator(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void SendMessage(string msg)
        {
            _mediator.Notify(this, msg);

        }
        public string GetDepartmentName()
        {
            return departmentName;
        }

    }
    public class TMD : EarlyWarningCollegues
    {
        public TMD()
        {
            base.departmentName = "Meteorological Department";
        }
        public override void ReceiveMsg(string msg, string departmentName)
        {
            Console.WriteLine($"Meteorological Department officially receives data from the  {departmentName} \n Content : {msg}");

        }
    }
    public class NSO : EarlyWarningCollegues
    {

       
        private List<string> _ListIncidentData { get; set; }
        public NSO()
        {
            _ListIncidentData = new List<string>();
            base.departmentName = "Statistical  Department";
        }
        public override void KeepData(string data)
        {
            //var incidentData = data + DateTime.Now.ToString();
            var incidentData = data;//+ DateTime.Now.ToString();
            if (_ListIncidentData.Count > 0)
            {
                foreach (string item in _ListIncidentData)
                {
                    if (!item.Equals(incidentData))
                    {
                        _ListIncidentData.Add(incidentData);
                    }
                }
            }
            else
            {
                _ListIncidentData.Add(incidentData);
            }

        }
        public override void ShowReport()
        {
            Console.WriteLine($"************** Report Viewer **************");
            foreach (var item in _ListIncidentData)
            {

                Console.WriteLine($"Content : {item}");
            }
        }

        public override void AnalysisData()
        {
            if (_ListIncidentData.Count > 0)
            {
                Console.WriteLine($"AnalysisData");

            }

        }
        public override void ReceiveMsg(string msg, string departmentName)
        {
            Console.WriteLine($"Statistical  Department  officially receives data from the  {departmentName} \n Content : {msg}");
        }
    }
    public class DMR : EarlyWarningCollegues
    {
        public DMR()
        {
            base.departmentName = "Department of Mineral Resources";
        }
        public override void ReceiveMsg(string msg, string departmentName)
        {

            Console.WriteLine($"Department of Mineral Resources officially receives data from the  {departmentName} \n Content : {msg}");

        }
    }
    public class MEA : EarlyWarningCollegues
    {
        public MEA()
        {
            base.departmentName = "Electricity Authority";
        }

        public override void ReceiveMsg(string msg, string departmentName)
        {
            Console.WriteLine($"Electricity Authority Receive  From : {departmentName} \n Content : {msg}");

        }
    }

}
