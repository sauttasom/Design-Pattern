using System;

namespace MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            VideoPlayer videoPlayer = new VideoPlayer("Tee yod");
            Caretaker caretaker = new Caretaker(videoPlayer);

            caretaker.AddHistory();
            videoPlayer.PauseVideo(10.5);
            caretaker.AddHistory();
            videoPlayer.PauseVideo(20);
            caretaker.AddHistory();
            videoPlayer.PauseVideo(1.55);


            Console.WriteLine($"Time Pause Now : {videoPlayer.GetPauseTimeVideo()}");

            caretaker.ShowHistory();
            caretaker.Undo();
            Console.WriteLine($"Time After  Undo Value : {videoPlayer.GetPauseTimeVideo()}");
           



        }
    }
}
