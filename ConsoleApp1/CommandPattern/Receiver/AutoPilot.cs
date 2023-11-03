using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Receiver
{
    internal class AutoPilotCommand : Command
    {
        private Car _car;
        public AutoPilotCommand(Car car) {
            this._car = car;
        }
        public void Execute()
        {
            _car.DriveAutoPilot();
        }
    }
}
