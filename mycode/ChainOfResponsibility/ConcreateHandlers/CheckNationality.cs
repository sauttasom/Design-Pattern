using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.ConcreateHandlers
{
    public class CheckNationality : Conscription
    {
        public override  void ValidatePerson(Person person)
        {
            Console.WriteLine("Check Nationalit");
            if (person != null)
            {
                if(person.ThaiNationality)
                {
                    //Console.WriteLine("Mr. " + person.Name + " Thai Nationality \n");
                    Console.WriteLine("Passed inspection Check Nationalit \n");
                    if (_handler != null)
                    {
                        _handler.ValidatePerson(person);
                    }
                }
                else
                {
                    Console.WriteLine("Mr. " + person.Name + " Not  Passed inspection Check Nationality");
                }

            }

        }
    }
}
