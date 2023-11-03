using IteratorPattern.Aggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public abstract class IStudentIterator
    {
        public abstract object  GetNext();
        public abstract bool hasMore();
    }
}
