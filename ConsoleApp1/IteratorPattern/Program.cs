

using IteratorPattern;
using IteratorPattern.Aggregate;
using IteratorPattern.ConcreteAggregate;
void ShowData(IStudentIterator studentIterator)
{
    while (studentIterator.hasMore())
    {
        Console.WriteLine(studentIterator.GetNext());
    }
}
BachelorDegreeConllection degreeConllection = new BachelorDegreeConllection();
degreeConllection.Add(new BachelorDegree("Jued", "215", "A"));
degreeConllection.Add(new BachelorDegree("Jued2", "254", "A"));
degreeConllection.Add(new BachelorDegree("Jued3", "255", "F"));

ShowData(degreeConllection.GetStudentInfo());

