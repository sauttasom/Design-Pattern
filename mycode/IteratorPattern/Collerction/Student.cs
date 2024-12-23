using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Collerction
{
    public interface IStudent
    {
        public double GetGrade();
        public string GetStudentInfo();
        public string GetDegree();

    }


    public class BachelorDegree : IStudent
    {
        private double Grade;
        private string Name;
        private string ID;
        private string Degree  = "BachelorDegree";
        public BachelorDegree( string name,  string id , double grade)
        {
            Grade = grade;
            Name = name;
            ID = id;
       
        }

        public string GetStudentInfo()
        {
            string info = $"---BachelorDegree--- \n Name : {Name} \n Student ID : {ID} \n Grade : {Grade} ";
            return info;
        }
        public double GetGrade()
        {
            return Grade;
        }
        public string GetDegree()
        {
            return Degree;
        }
    }
    public class MasterDegree : IStudent
    {
        private double Grade;
        private string Name;
        private string ID;
        private string Degree = "MasterDegree";
        public MasterDegree(string name, string id, double grade)
        {
            Grade = grade;
            Name = name;
            ID = id;

        }
        public string GetStudentInfo()
        {
            string info = $"---MasterDegree--- \n Name : {Name} \n Student ID : {ID} \n Grade : {Grade} ";
            return info;
        }
        public double GetGrade()
        {
            return Grade;
        }
        public string GetDegree()
        {
            return Degree;
        }
    }

  
}
