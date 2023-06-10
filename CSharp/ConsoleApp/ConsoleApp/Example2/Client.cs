using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Example2
{
    // Client code
    public class Client
    {
        private readonly ILog log;

        public Client(ILog log)
        {
            this.log = log;
        }

        public void DoWork()
        {
            // Use the log (through the adapter) to log messages
            log.LogMessage("Message 1");
            log.LogMessage("Message 2");
            log.LogMessage("Message 3");
        }
    }
}
