using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{



    public interface ConscriptHandler
    {
        public ConscriptHandler SetNext(ConscriptHandler h);
        public void ValidatePerson(Person person);
    }
    public abstract  class Conscription : ConscriptHandler
    {
        protected ConscriptHandler _handler;

        public ConscriptHandler SetNext(ConscriptHandler h)
        {
            _handler = h;
            return _handler;
        }
        public abstract void ValidatePerson(Person person);

     
    }
}
