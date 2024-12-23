


using MediatorPattern;


var mea = new MEA();
var tdm = new TMD();
var dmr = new DMR();
var nso = new NSO();
var listdata = new List<EarlyWarningCollegues>() { };
listdata.Add(mea);
listdata.Add(tdm);
listdata.Add(dmr);
listdata.Add(nso);


var mediator = new AppMediator(listdata);
mea.SendMessage("There was an electrical malfunction causing a power outage.");
Console.WriteLine("\n");

dmr.SendMessage("On October 8, 2023, Mr. Karom Phonphonklang, deputy director of the offices");
Console.WriteLine("\n");


tdm.SendMessage("All sky conditions are unchanged. 31°. All sky conditions are unchanged. Rainfall 0.0");
Console.WriteLine("\n");


nso.ShowReport();

