// See https://aka.ms/new-console-template for more information
using ChainOfResponsibility;
using ChainOfResponsibility.ConcreateHandlers;
using System;


void Client(Person person)
{

    CheckBody checkBody = new CheckBody();
    CheckNationality checkNationality = new CheckNationality();
    DrugTest drugTest = new DrugTest();
    Deferment deferment = new Deferment();
    CatchTheCard catchTheCard = new CatchTheCard();

    checkBody.SetNext(checkNationality).SetNext(drugTest).SetNext(deferment).SetNext(catchTheCard);
    Console.WriteLine("Mr." + person.Name + "\n");
    checkBody.ValidatePerson(person);

}



var personList = new List<Person>
{
    new Person
    {
        Name = "John Doe",
        Gender = true, // Male
        Tall = 180,
        Age = 21,
        Drug = false,
        Deferment = false,
        CanCatch = false,
        ThaiNationality = true
    },
    new Person
    {
        Name = "Alice Brown",
        Gender = true, // Female
        Tall = 160,
        Age = 21,
        Drug = false,
        Deferment = false,
        CanCatch = true,
        ThaiNationality = true
    },
};




foreach (var p in personList)
{

    Client(p);
}

