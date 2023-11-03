using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.ConcreateHandlers
{
    public class DrugTest : Conscription
    {
        public override void ValidatePerson(Person person)
        {
            Console.WriteLine("DrugTest");
            if (person != null)
            {
                if (!person.Drug)
                {
                 
                    Console.WriteLine("Passed inspection Check Drug \n");
                    //_handler.ValidatePerson(person);
                    if (_handler != null)
                    {
                        _handler.ValidatePerson(person);
                    }
                }
                else
                {
                    Console.WriteLine("Mr. " + person.Name + " Not  Passed inspection Check Drug");
                }

            }

        }
    }
}
