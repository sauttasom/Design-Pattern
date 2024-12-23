using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public interface Originator
    {
        public IMemento SaveMemento();
        public void Restore(IMemento memento);
    }

    public class VideoPlayer : Originator
    {
        private string _VideoName ;
        private double _PauseTimeVideo;
        public VideoPlayer(string n)
        {
            Console.WriteLine($"Playing video: {n}  \n");
            _VideoName = n;
            _PauseTimeVideo = 0.0;
        }

        public void PauseVideo(double timevalue)
        {
           // Console.WriteLine($"Pausing video.");
            _PauseTimeVideo = timevalue;
        }
        public double GetPauseTimeVideo()
        {
            return _PauseTimeVideo;
        }
        public string GetVideoName()
        {
            return _VideoName;
        }
        public void SetTimePause(double timevalue)
        {
            _PauseTimeVideo = timevalue;
        }
      

        public IMemento SaveMemento()
        {
            return new VideoPlayerMemento(this._VideoName, _PauseTimeVideo);
        }

        public void Restore(IMemento memento)   
        {
            var mementoVideo = (VideoPlayerMemento)memento;
            var timelog = mementoVideo.GetDatePause();
            Console.WriteLine($"Restore  {_PauseTimeVideo} To {timelog}   \n");
            SetTimePause(timelog);
        }


    }


}
