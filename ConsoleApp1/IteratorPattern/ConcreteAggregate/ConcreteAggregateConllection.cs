using IteratorPattern.Aggregate;
using IteratorPattern.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.ConcreteAggregate
{
    public interface IStudentCollection<T>
    {
        public IStudentIterator GetStudentInfo();
        public int Getlength();

        T this[int index] { get; set; }
    }

    public  class BachelorDegreeConllection : IStudentCollection<BachelorDegree>
    {
        private List<BachelorDegree> _bachelorDegrees { get; set; }
       // private List<object> items = new List<object>();

        public BachelorDegreeConllection()
        {
            _bachelorDegrees = new List<BachelorDegree>();
        }
        public void Add(BachelorDegree bachelorDegree)
        {
            _bachelorDegrees.Add(bachelorDegree);
        }

        public int Getlength()
        {
            int count = _bachelorDegrees.Count;
            return count;
        }

        public BachelorDegree this[int index]
        {
            get { return _bachelorDegrees[index]; }
            set { _bachelorDegrees[index] = value; }
        }

        public IStudentIterator GetStudentInfo()
        {
            return new GetStudentInformation<BachelorDegree>(this);
        }
    }


    public class MasterDegreeStudentConllection : IStudentCollection<MasterDegree>
    {
        private List<MasterDegree> _masterDegrees = new List<MasterDegree>();
        
        public MasterDegreeStudentConllection()
        {
            _masterDegrees = new List<MasterDegree>();

        }
        public int Getlength()
        {
            return _masterDegrees.Count;
        }
  
        public void Add(MasterDegree masterDegree)
        {
            _masterDegrees.Add(masterDegree);
        }
        public MasterDegree this[int index]
        {
            get { return _masterDegrees[index]; }
            set { _masterDegrees[index] = value; }
        }


        public IStudentIterator GetStudentInfo()
        {
            return new GetStudentInformation<MasterDegree>(this);
        }
    }
}
