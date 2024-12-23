
using IteratorPattern.Collerction;
using IteratorPattern.ConcreteAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Iterator
{
    public abstract class IStudentIterator
    {
        public abstract IStudent GetNext();
        public abstract bool hasMore();
    }

    public class GetStudentInfoIterator : IStudentIterator
    {
        private List<IStudent> Studentcollection;
        private int currentIndex;
        private int endIndex;
        public GetStudentInfoIterator(IStudentCollection s)
        {
            Studentcollection = new List<IStudent>();
            if (s != null)
            {
                for (int i = 0; i < s.GetCount(); i++)
                {
                   
                    if (!string.IsNullOrEmpty(s[i].GetStudentInfo()))
                    {
                        Studentcollection.Add(s[i]);
                    }
                }
                endIndex = Studentcollection.Count;
                currentIndex = 0;
            }
        }

        public override IStudent GetNext()
        {

            if (currentIndex < endIndex)
            {

                return Studentcollection[currentIndex++];
            }
            else
            {
                throw new InvalidOperationException("No more items to return.");
            }
        }


        public override bool hasMore()
        {
            return currentIndex < endIndex;
        }
    }
    public class GetHonorary_Iterator : IStudentIterator
    {
     
        private List<IStudent> Studentcollection;
        private int currentIndex;
        private int endIndex;
        public GetHonorary_Iterator(IStudentCollection s)
        {

            Studentcollection  = new List<IStudent>();
            if(s != null )
            {
                for (int i = 0; i < s.GetCount(); i++)
                {
                    if (s[i].GetGrade() >= 3.8)
                    {

                        Studentcollection.Add(s[i]);
                    }
                }
                endIndex = Studentcollection.Count;
                currentIndex = 0;
            }
        }

        public override IStudent GetNext()
        {
            if (currentIndex < endIndex)
            {
                return Studentcollection[currentIndex++];
            }
            else
            {
                throw new InvalidOperationException("No more items to return.");
            }
        }

        public override bool hasMore()
        {
            return currentIndex < endIndex;
        }
    }
    public class GetExcellentGrade_Iterator : IStudentIterator
    {
        private List<IStudent> Studentcollection;
        private int currentIndex;
        private int endIndex;
        public GetExcellentGrade_Iterator(IStudentCollection s)
        {
            Studentcollection = new List<IStudent>();
            if (s != null)
            {
                for (int i = 0; i < s.GetCount(); i++)
                {
                    if (s[i].GetGrade() >= 3.5 &&  s[i].GetGrade() <= 3.7)
                    {
                        Studentcollection.Add(s[i]);
                    }
                }
                endIndex = Studentcollection.Count;
                currentIndex = 0;
            }
        }

        public override IStudent GetNext()
        {
            if (currentIndex < endIndex)
            {
                return Studentcollection[currentIndex++];
            }
            else
            {
                throw new InvalidOperationException("No more items to return.");
            }
        }

        public override bool hasMore()
        {
            return currentIndex < endIndex;
        }
    }
}
