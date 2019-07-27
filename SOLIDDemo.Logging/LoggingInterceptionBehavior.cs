using SOLIDDemo.Interfaces;
using System;
using System.Collections.Generic;
using Unity.Interception.InterceptionBehaviors;
using Unity.Interception.PolicyInjection.Pipeline;

namespace SOLIDDemo.Logging
{
    public class LoggingInterceptionBehavior : IInterceptionBehavior
    {
        ILogger _logger;

        public LoggingInterceptionBehavior(ILogger logger)
        {
            _logger = logger;
        }

        public bool WillExecute => true;

        public IEnumerable<Type> GetRequiredInterfaces()
        {
            return Type.EmptyTypes;
        }

        public IMethodReturn Invoke(IMethodInvocation input, GetNextInterceptionBehaviorDelegate getNext)
        {
            _logger.LogMessage($"{input.MethodBase}");
            _logger.LogInput(input.Inputs);

            var result = getNext()(input, getNext);

            if (result.Exception != null)
            {
                _logger.LogException(result.Exception);

                // Swallow exception
                result.Exception = null;
                result.ReturnValue = null;
            }

            _logger.LogOutput(result.Outputs);
            _logger.LogMessage($"{input.MethodBase} returned: {result.ReturnValue}");

            return result;
        }
    }
}