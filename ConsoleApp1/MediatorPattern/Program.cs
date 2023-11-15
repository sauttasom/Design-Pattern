


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
mea.SendMessage("Provincial Electricity Authority Announcement on Electricity Tariffs ");
Console.WriteLine("\n");
tdm.SendMessage("All sky conditions are unchanged. 31°. All sky conditions are unchanged. Rainfall 0.0");
Console.WriteLine("\n");
dmr.SendMessage("Department of Mineral Resources It is a department level agency. Under the Ministry of Natural Resources and Environment");
Console.WriteLine("\n");

nso.ShowReport();

