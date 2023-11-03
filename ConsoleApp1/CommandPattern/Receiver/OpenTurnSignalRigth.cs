using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Receiver
{
    public class OpenTurnSignalCommand : Command
    {
        private Car _Car { get; set; }
        private bool _side = false;
        public OpenTurnSignalCommand(Car car, bool side) 
        { 
            _Car = car;
            _side = side;
        }
        public void Execute()
        {
            _Car.OpenTurnSignal(_side);
        }
    }
}
