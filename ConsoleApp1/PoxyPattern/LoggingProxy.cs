using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoxyPattern
{
    interface ILoggingSubsystem
    {
        void Log(string message);
    }
    // Real 
    class RealLoggingSubsystem : ILoggingSubsystem
    {
        public void Log(string message)
        {
            Console.WriteLine($"[Log]: {message}");
        }
    }

    //Temp
    class ProxyLoggingSubsystem : ILoggingSubsystem
    {
        private ILoggingSubsystem realLogger;
        private List<string> logBuffer = new List<string>();
        private bool isTestingMode = false;

        public ProxyLoggingSubsystem()
        {
   
            realLogger = new RealLoggingSubsystem();
        }

        public void Log(string message)
        {
            if (isTestingMode)
            {
                logBuffer.Add(message);
            }
            else
            {
                realLogger.Log(message);
            }
        }

        public void SetTestingMode(bool testingMode)
        {
            isTestingMode = testingMode;

            if (!testingMode)
            {
               
                foreach (var message in logBuffer)
                {
                    realLogger.Log(message);
                }
                logBuffer.Clear();
            }
        }
    }

}
