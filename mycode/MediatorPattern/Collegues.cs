using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MediatorPattern
{
    public abstract class EarlyWarningCollegues
    {
        public IMediator _mediator { get; private set; }
        protected string departmentName { get; set; }
        protected string address { get; set; }
        public abstract void ReceiveMsg(string msg, string departmentName);
        public virtual void KeepData(string data) { }
        //public virtual void AnalysisData() { }
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
        private int Level { get; set; }

        public void SetLevelWater(int l) { 
            Level = l;
        }

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
            var incidentData = data + " Date :" +  DateTime.Now.ToString();
            
            if (_ListIncidentData.Count > 0)
            {
             
                var datalist = _ListIncidentData.ToList();
                foreach (string item in datalist)
                {
                  
                    if (!item.Equals(data))
                    {
                        
                        _ListIncidentData.Add(data);
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


        public override void ReceiveMsg(string msg, string departmentName)
        {
            Console.WriteLine($"Statistical  Department  officially receives data from the  {departmentName} \n Content : {msg}");
        }
    }
    public class DMR : EarlyWarningCollegues
    {

        private bool isRefugeeOn { get; set; }
        public void SetisRefugeeOn(bool s)
        {
            isRefugeeOn = s;
        }
        public DMR()
        {
            base.departmentName = "Disaster Prevention and Mitigation";
        }
        public void SetAddress(string a)
        {
            base.address = a;
        }
        public override void ReceiveMsg(string msg, string departmentName)
        {

            Console.WriteLine($"Disaster Prevention and Mitigation officially receives data from the  {departmentName} \n Content : {msg}");

        }
    }
    public class MEA : EarlyWarningCollegues
    {
        private bool _TurnElectricity { get; set; }
        public void DisableEctricity(bool on)
        {
            _TurnElectricity = on;

        }
        public void SetAddress(string a)
        {
            base.address = a;
        }
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
