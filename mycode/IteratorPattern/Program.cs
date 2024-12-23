
using IteratorPattern.Collerction;
using IteratorPattern.ConcreteAggregate;
using IteratorPattern.Iterator;
using System.Diagnostics;
using System.Xml.Linq;

void ShowData(IStudentIterator studentIterator)
{
    while (studentIterator.hasMore())
    {
        var data = studentIterator.GetNext().GetStudentInfo();
        Console.WriteLine(data);
    }
}


var bachelorConllection = new BachelorDegreeStudentConllection();


bachelorConllection.AddStudent(new BachelorDegree("John", "60050034", 3.5));
bachelorConllection.AddStudent(new BachelorDegree("Alice", "60050036", 3.5));
bachelorConllection.AddStudent(new BachelorDegree("Bob", "60050037", 3.5));
bachelorConllection.AddStudent(new BachelorDegree("Eva", "60050038", 3.5));
bachelorConllection.AddStudent(new BachelorDegree("David", "60050039", 4.0));
bachelorConllection.AddStudent(new BachelorDegree("Jued", "60050040", 4.0));
bachelorConllection.AddStudent(new BachelorDegree("John", "60050043", 3.5));


Console.WriteLine("**************** Student Info ****************");
ShowData(bachelorConllection.IteratorGetStudentInfo());
Console.WriteLine("**************** Student Honorary Info ****************");
ShowData(bachelorConllection.IteratorGetStudentHonoraryGrade());
Console.WriteLine("**************** Student Excellent Info ****************");
ShowData(bachelorConllection.IteratorGetExcellentGrade());





var masterConllection = new MasterDegreeStudentConllection();


masterConllection.AddStudent(new MasterDegree("Correna", "60050034", 3.5));
masterConllection.AddStudent(new MasterDegree("Nicholle", "60050036", 3.5));
masterConllection.AddStudent(new MasterDegree("Carie", "60050037", 3.5));
masterConllection.AddStudent(new MasterDegree("Aaren", "60050038", 3.8));
masterConllection.AddStudent(new MasterDegree("Ninnette", "60050039", 4.0));
masterConllection.AddStudent(new MasterDegree("Sofie", "60050040", 4.0));



Console.WriteLine("**************** Student Info ****************");
ShowData(masterConllection.IteratorGetStudentInfo());
Console.WriteLine("**************** Student Honorary Info ****************");
ShowData(masterConllection.IteratorGetStudentHonoraryGrade());
Console.WriteLine("**************** Student Excellent Info ****************");
ShowData(masterConllection.IteratorGetExcellentGrade());
