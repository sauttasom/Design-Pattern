using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.ConcreateHandlers
{
    public class Deferment : Conscription
    {
        public override void ValidatePerson(Person person)
        {
            Console.WriteLine("Deferment");
            if (person != null)
            {
                if (!person.Deferment)
                {
                    //Console.WriteLine("Mr. " + person.Name + " Can Catch Card \n");
                    Console.WriteLine("Can Catch The Card \n");
                    person.CanCatch = true;
                    //_handler.ValidatePerson(person);
                    if (_handler != null)
                    {
                        _handler.ValidatePerson(person);
                    }
                }
                else
                {
                    person.CanCatch = false;
                    Console.WriteLine("Mr. " + person.Name + " Deferment Conscription 2 year");
                }

            }

        }
    }
}
