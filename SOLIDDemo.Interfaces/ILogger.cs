using System;
using Unity.Interception.PolicyInjection.Pipeline;

namespace SOLIDDemo.Interfaces
{
    public interface ILogger
    {
        void LogMessage(string message);
        void LogException(Exception exception);
        void LogInput(IParameterCollection inputs);
        void LogOutput(IParameterCollection outputs);
    }
}