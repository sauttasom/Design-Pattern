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

                dep.ShowReport();
            }
        }

        public void Notify(EarlyWarningCollegues sender, string msg)
        {
            int i = 0;
            foreach (var receiver in EarlyWarningColleguesList)
            {
                var senderName = sender.GetDepartmentName();
                string receiverName = receiver.GetDepartmentName();


                if (receiverName.Equals("Statistical  Department"))
                {
                    
                    receiver.KeepData(msg);
                }



                //กรมไฟฟ้า ส่งไปแจ้ง กรมอุตุวิทยา
                if (senderName.Equals("Electricity Authority") && receiverName.Equals("Meteorological Department"))
                {

                    receiver.ReceiveMsg(msg, senderName);

                    var mea = sender as MEA;
                    mea.SetAddress("near Soi Sukhumwi22.");
                    mea.DisableEctricity(false);

       
                }

                //กรมอุตุวิทยา ส่งไปแจ้ง กรมอุทกภัย    
                if (senderName.Equals("Meteorological Department") && receiverName.Equals("Disaster Prevention and Mitigation"))
                {
                    receiver.ReceiveMsg(msg, senderName);
                    var tdm = sender as TMD;
                    tdm.SetLevelWater(5);

                    var dMR = receiver as DMR;
                    dMR = new DMR();
                    dMR.SetisRefugeeOn(true);

                }

                //กรมอุทกภัย ส่งไปแจ้ง กรมไฟฟ้า
                if (senderName.Equals("Disaster Prevention and Mitigation") && receiverName.Equals("Electricity Authority"))
                {
                    receiver.ReceiveMsg(msg, senderName);
                    var dMR = sender as DMR;
                    dMR.SetAddress("in Pha Kan subdistrict 35/1. mountain area");

                    var mea = receiver as MEA;
                    mea.DisableEctricity(true);
                }

            }
        }
    }


}
