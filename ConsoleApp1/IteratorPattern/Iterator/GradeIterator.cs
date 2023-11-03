using IteratorPattern.Aggregate;
using IteratorPattern.ConcreteAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Iterator
{
    public class GetStudentInformation<T> : IStudentIterator
    {
 
       // private List<Student> _stduentCollection = new List<Student>();
        private IStudentCollection<T> _stduentCollection;
        private IStudentCollection<T> collection;
        private int currentIndex = 0;
        private int endIndex = 0;
        public GetStudentInformation(IStudentCollection<T> studuentCollection)
        {
            if(studuentCollection != null)
            {
                //_stduentCollection.Add((Student)studuentCollection);

                endIndex = studuentCollection.Getlength();
                _stduentCollection = studuentCollection;
                
            }
         
        }

        public override object GetNext()
        {
            Student nextData = null;
            if (hasMore())
            {
                T item = _stduentCollection[++currentIndex];
          
                return item;

            }
            else
            {
                return null;
            }

        }

        public override bool hasMore()
        {
            return currentIndex < endIndex;
        }
    }
}
