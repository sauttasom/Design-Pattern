using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class Remote
    {
        private Command _command { get; set; }   

        public void setCommand(Command command)
        {
            _command = command;
        }
        public void ExcuteCommand()
        {
            _command.Execute();
        }
    }
}
