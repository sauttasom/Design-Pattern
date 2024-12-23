using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public interface IPublisher
    {
        public void Subscribe(IObserver observer);
        public void Unsubscribe(IObserver observer);
        public void Notify();
    }
    public class CloudPublisher : IPublisher
    {
        private List<IObserver> _observers = new List<IObserver>();
        public string message { get; set; }
        public void Notify()
        {
            foreach(var item in _observers)
            {
                item.Update(message);
            }
           
        }
        //public void setMessage(string m)
        //{
        //    message = m;
        //    Notify();
        //}

        public void Subscribe(IObserver observer)
        {

            _observers.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            _observers.Remove(observer);
         
        }
    }
}
