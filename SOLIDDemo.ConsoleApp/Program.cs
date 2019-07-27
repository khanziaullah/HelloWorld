using SOLIDDemo.Interfaces;
using SOLIDDemo.Logging;
using SOLIDDemo.Logic;
using System.ComponentModel;
using Unity;
using Unity.Injection;
using Unity.Interception;
using Unity.Interception.ContainerIntegration;
using Unity.Interception.InterceptionBehaviors;
using Unity.Interception.Interceptors.InstanceInterceptors.InterfaceInterception;

namespace SOLIDDemo.ConsoleApp
{
    class Program
    {
        static IUnityContainer _container;
        static void Main(string[] args)
        {
            _container = new UnityContainer();
            _container.AddNewExtension<Interception>();

            _container.RegisterType<ILogger, ConsoleLogger>();
            _container.RegisterType<ILogger, DiagnosticsLogger>();

            _container.RegisterType<IInterceptionBehavior, LoggingInterceptionBehavior>();

            _container.RegisterType<IMessageReader, ConsoleMessageReader>(
                new Interceptor<InterfaceInterceptor>(),
                new InterceptionBehavior<IInterceptionBehavior>());

            _container.RegisterType<IMessageWriter, ConsoleMessageWriter>();

            var startup = _container.Resolve<Startup>();

            startup.Run();
        }
    }
}
