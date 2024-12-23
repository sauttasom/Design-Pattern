using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Car
    {
        public Car() {
            Console.WriteLine("Car :  Command Starting ");
        }
        public void OpenTurnSignal(bool side)
        {
            if (side)
            {
                Console.WriteLine("Car : OpenTurnSignal Rigth");
            }
            else
            {
                Console.WriteLine("Car : OpenTurnSignal Left");
            }
        }
        public void MoveBackward()
        {

            Console.WriteLine("Car :  MoveBackward");

        }
        public void DriveAutoPilot()
        {
            Console.WriteLine("Car :  AutoPilot");
        }
    }
}
