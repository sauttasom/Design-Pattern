using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.ConcreateHandlers
{
    public class CheckBody : Conscription
    {
        public override void ValidatePerson(Person person)
        {
            bool isResult = true;  
            string messageResult = string.Empty;
            Console.WriteLine("Check Body : ");
            if (person != null)
            {
                if (string.IsNullOrEmpty(person.Name))
                {
                    isResult = false;
                    messageResult = "Name is invalid \n";
                }
                if(!person.Gender)
                {
                    isResult = false;
                    messageResult += "Gender not Male\n";
                }
                if (person.Age != 21 )
                {
                    isResult = false;
                    messageResult += "Age not equal to 21 year old\n";
                }
                if (person.Tall < 160)
                {
                    isResult = false;
                    messageResult += "Tall less than 160 CM\n";
                }

                if (isResult)
                {
                    Console.WriteLine("Result Check Body Passed inspection \n");

                  
                    if (_handler != null)
                    {
                        _handler.ValidatePerson(person);
                    }
                }
                else
                { 
                    Console.WriteLine("Mr. " + person.Name + " Not Passed inspection Check Body  Because \n");
                    Console.WriteLine(messageResult);
                }

            }

        }
    }
}
