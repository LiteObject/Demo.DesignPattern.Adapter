using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Example2
{
    // Adapter
    public class LoggerAdapter : ILog
    {
        private readonly Logger logger;

        public LoggerAdapter(Logger logger)
        {
            this.logger = logger;
        }

        public void LogMessage(string message)
        {
            // Call the Adaptee's method
            logger.Log(message);
        }
    }
}
