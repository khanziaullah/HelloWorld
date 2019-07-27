using SOLIDDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Interception.PolicyInjection.Pipeline;

namespace SOLIDDemo.Logging
{
    public class DiagnosticsLogger : ILogger
    {
        public void LogMessage(string message)
        {
            Debug.WriteLine(message);
        }

        public void LogException(Exception exception)
        {
            Debug.WriteLine($"{exception.Message}");
            Debug.WriteLine($"{exception.StackTrace}");
        }

        public void LogInput(IParameterCollection inputs)
        {
            foreach (var input in inputs)
            {
                Debug.WriteLine(input);
            }
        }

        public void LogOutput(IParameterCollection outputs)
        {
            foreach (var output in outputs)
            {
                Debug.WriteLine(output);
            }
        }
    }
}
