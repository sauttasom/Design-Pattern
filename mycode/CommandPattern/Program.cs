// See https://aka.ms/new-console-template for more information
using CommandPattern;
using CommandPattern.Receiver;

Console.WriteLine("Hello, World!");
Remote remote = new Remote();
var car = new Car();


var left = false;
var right = true;

remote.setCommand(new OpenTurnSignalCommand(car, left));
remote.ExcuteCommand();


remote.setCommand(new OpenTurnSignalCommand(car, right));
remote.ExcuteCommand();

remote.setCommand(new MoveBackwardCommand(car));
remote.ExcuteCommand();


remote.setCommand(new AutoPilotCommand(car));
remote.ExcuteCommand();


