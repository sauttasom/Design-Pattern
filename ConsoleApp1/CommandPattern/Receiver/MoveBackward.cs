using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Receiver
{
    internal class MoveBackwardCommand : Command
    {
        private Car _Car { get; set; }
        public MoveBackwardCommand(Car car) 
        { 
            _Car = car;
        }

        public void Execute()
        {
            _Car.MoveBackward();
        }
    }
}
