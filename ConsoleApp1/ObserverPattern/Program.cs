using System;

namespace ObserverPattern
{
    class Program
    {

        static void Main(string[] args)
        {
            CloudPublisher cloudPublisher = new CloudPublisher();
            var emailA = new Email("manee@gmail.com");
            var emailB = new Email("PaterParker@gmail.com");

            var annaSMS = new SMS("098-541-8453");
            var fakerSMS = new SMS("08-664-6541");
            cloudPublisher.Subscribe(emailA);
            cloudPublisher.Subscribe(emailB);
            cloudPublisher.Subscribe(annaSMS);
            cloudPublisher.Subscribe(fakerSMS);


            //cloudPublisher.setMessage("How to Remove an Item From a List Using the Remove() Method");
            cloudPublisher.message = "How to Remove an Item From a List Using the Remove() Method";
            cloudPublisher.Notify();

            Console.WriteLine("-----------After Unsubscribe-----------");
            cloudPublisher.Unsubscribe(emailA);

            cloudPublisher.message = "C# Observer Pattern";
            cloudPublisher.Notify();
        }
    }
}
