using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public interface IObserver
    {
        public void Update(string message);
    }


    public class Email : IObserver
    {
        private string messageFromPublisher;
        private string _email;
        public Email(string email)
        {
            _email = email;

        }
        public void Update(string message)
        {
            messageFromPublisher = message;
            ShowMessage();
        }
        public void ShowMessage()
        {
            Console.WriteLine($"Email Notity : {_email} \n Message : {messageFromPublisher}  ");
        }
    }
    public class SMS : IObserver
    {

        private string messageFromPublisher;
        private string _phoneNumber;
        public SMS(string phoneNumber)
        {
            _phoneNumber = phoneNumber;

        }
        public void Update(string message)
        {
            messageFromPublisher = message;
            ShowMessage();
        }
        public void ShowMessage()
        {
            Console.WriteLine($"SMS To Phone Number {_phoneNumber} \n Message : {messageFromPublisher}  ");
        }
    }
}
