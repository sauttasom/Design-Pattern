using IteratorPattern.Collerction;
using IteratorPattern.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace IteratorPattern.ConcreteAggregate
{
    public interface IStudentCollection
    {
        public void AddStudent(IStudent student);
        public IStudentIterator IteratorGetStudentInfo();
        public IStudentIterator IteratorGetStudentHonoraryGrade();
        public IStudentIterator IteratorGetExcellentGrade();
        public IStudent this[int index] { get; }
        public int GetCount();

    }

    public class BachelorDegreeStudentConllection : IStudentCollection
    {
        private List<BachelorDegree> BachelorDegreeList;
        private int currentindex = 0;
        public BachelorDegreeStudentConllection()
        {
            BachelorDegreeList = new List<BachelorDegree>();
        }
        public int GetCount()
        {
            return BachelorDegreeList.Count();
        }

        public IStudentIterator IteratorGetStudentInfo()
        {
            return new GetStudentInfoIterator(this);

        }
        public IStudentIterator IteratorGetStudentHonoraryGrade()
        {
            return new GetHonorary_Iterator(this);
        }

        public IStudentIterator IteratorGetExcellentGrade()
        {
            return new GetExcellentGrade_Iterator(this);

        }

        public void AddStudent(IStudent student)
        {
            if (student != null)
            {
                BachelorDegreeList.Add((BachelorDegree)student);
            }

        }
        public IStudent this[int i]
        {
            get
            {
                if (i >= 0 && i < BachelorDegreeList.Count)
                {
                    return BachelorDegreeList[i];
                }
                else
                {
                    throw new IndexOutOfRangeException("Index is out of bounds");

                }
            }
        }
    }



    public class MasterDegreeStudentConllection : IStudentCollection
    {
        private int currentindex = 0;
        private List<MasterDegree> _MasterDegreeList;
        public MasterDegreeStudentConllection()
        {
            _MasterDegreeList = new List<MasterDegree>();
        }
        public int GetCount()
        {
            return _MasterDegreeList.Count();
        }
        public IStudentIterator IteratorGetStudentInfo()
        {
            return new GetStudentInfoIterator(this);

        }
        public IStudentIterator IteratorGetStudentHonoraryGrade()
        {
            return new GetHonorary_Iterator(this);
        }

        public IStudentIterator IteratorGetExcellentGrade()
        {
            return new GetExcellentGrade_Iterator(this);

        }

        public void AddStudent(IStudent student)
        {
            if (student != null)
            {
                _MasterDegreeList.Add((MasterDegree)student);
            }

        }
        public IStudent this[int i]
        {
            get
            {
                if (i >= 0 && i < _MasterDegreeList.Count)
                {
                    return _MasterDegreeList[i];
                }
                else
                {
                    throw new IndexOutOfRangeException("Index is out of bounds");

                }
            }
        }
    }

}
