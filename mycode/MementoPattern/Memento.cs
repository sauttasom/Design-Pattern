using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{

    public interface IMemento
    {
        public void Show();
    }
    public class VideoPlayerMemento : IMemento
    {
        private double _DatePause;
        private string _VideoName;
        public VideoPlayerMemento(string n , double datePause)
        {
           
            _VideoName = n; 
            _DatePause = datePause;
        }
  

        public void Show()
        {
            Console.WriteLine($"Time Pause List :{_DatePause}");
        }

        public double GetDatePause()
        {
            return _DatePause;
        }


        public string  GetName()
        {
            return _VideoName;
        }

    }


    public class Caretaker
    {
        private Originator _originator;
        private List<IMemento> _history = new List<IMemento>();
        public Caretaker(Originator o)
        {
          
            _originator = o;

        }
        public void AddHistory()
        {
        
            _history.Add(_originator.SaveMemento());
        }
        public void Undo()
        {
            if (_history.Count < 0)
                return;


            var videoMemeto = _history.LastOrDefault();
            _originator.Restore(videoMemeto);
            _history.Remove(videoMemeto);

       
      
        }
        public void  ShowHistory()
        {
            Console.WriteLine("************ShowHistory****************");
            foreach(var item in _history)
            {
                item.Show();
            }

        }


    }
}
