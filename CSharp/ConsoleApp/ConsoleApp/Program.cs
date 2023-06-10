using ConsoleApp.Example1;
using ConsoleApp.Example2;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /******************************************************
             * EXAMPLE #1
             *****************************************************/

            // Create the Adaptee (LegacyCar)
            LegacyCar legacyCar = new();

            // Create the Adapter (CarAdapter)
            CarAdapter adapter = new(legacyCar);

            // Create the Client
            Example1.Client client = new();
            client.StartEngine(adapter);

            /******************************************************
             * EXAMPLE #2
             *****************************************************/

            // Create the Adaptee (Logger)
            Logger logger = new();

            // Create the Adapter (LoggerAdapter)
            LoggerAdapter adapter2 = new(logger);

            // Create the Client
            Example2.Client client2 = new(adapter2);

            // Use the adapter to log messages
            client2.DoWork();
        }
    }
}