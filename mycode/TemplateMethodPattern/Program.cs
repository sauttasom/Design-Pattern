using TemplateMethodPattern;

//Console.WriteLine("--------------RunningTracker-------------");

//var runningTracker = new RunningTracker();
//runningTracker.Track();


//Console.WriteLine("\n");
//Console.WriteLine("--------------YogaTracker-------------");


//var yogaTracker = new YogaTracker();
//yogaTracker.Track();

MuayThai muayThai = new MuayThai();
muayThai.BoxingFightProgrom();
Console.WriteLine("---------------------------");

MMABoxing mmaBoxing = new MMABoxing();
mmaBoxing.BoxingFightProgrom();

Console.ReadLine();