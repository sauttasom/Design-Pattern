using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ChainOfResponsibility.ConcreateHandlers
{
    public class CatchTheCard : Conscription
    {
        public override void ValidatePerson(Person person)
        {
            Console.WriteLine("********* CatchTheCard *********");
            if (person != null)
            {
                if (person.CanCatch)
                {
                   
                    var redCard = false;
                    Random rnd = new Random();
                    int num = rnd.Next();
                    if (num % 2 == 0)
                    {
                        redCard = true;
                    }

                    if (_handler != null)
                    {
                        _handler.ValidatePerson(person);
                    }

                    Console.WriteLine("Mr. " + person.Name + " Catch Card Result ");
                    if (redCard)
                    {
                        Console.WriteLine("Red Card You were not chosen for military service. T_T \n");
                    }
                    else
                    {
                        Console.WriteLine("Black Card Your are  The soldier . Congratulation!! \n");
                    }
                }
                else
                {
                    Console.WriteLine("Mr. " + person.Name + " Deferment Conscription 2 year");
                }

            }

        }
    }
}
