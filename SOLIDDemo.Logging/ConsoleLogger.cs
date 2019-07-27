using SOLIDDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Interception.PolicyInjection.Pipeline;

namespace SOLIDDemo.Logging
{
    public class ConsoleLogger : ILogger
    {
        public void LogMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void LogException(Exception exception)
        {
            Console.WriteLine($"{exception.Message}");
            Console.WriteLine($"{exception.StackTrace}");
        }

        public void LogInput(IParameterCollection inputs)
        {
            foreach (var input in inputs)
            {
                Console.WriteLine(input);
            }
        }

        public void LogOutput(IParameterCollection outputs)
        {
            foreach (var output in outputs)
            {
                Console.WriteLine(output);
            }
        }
    }
}
