using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Aggregate
{
    public abstract class Student
    {
        public abstract string GetStudent();

    }
    public class  BachelorDegree : Student
    {
        private string StudentName;
        private string StudentID;
        private string _Grade;
        public BachelorDegree(string studentName, string studentID, string grade)
        {
            StudentName = studentName;
            StudentID = studentID;
            _Grade = grade;
        }


        public override string GetStudent()
        {
            string student = $"StudentID : {StudentID} \n StudentName : {StudentName} \n Grade : {_Grade} \n";
            return student;
        }
    }
    public class MasterDegree : Student
    {
        private string StudentName;
        private string StudentID;
        private string _Grade;
        public override string GetStudent()
        {
            string student = $"StudentID : {StudentID} \n StudentName : {StudentName} \n Grade : {_Grade} \n";
            return student;
        }

    }

        


}
