using SOLIDDemo.Interfaces;
using SOLIDDemo.Logging;
using SOLIDDemo.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Interception;
using Unity.Interception.ContainerIntegration;
using Unity.Interception.InterceptionBehaviors;
using Unity.Interception.Interceptors.InstanceInterceptors.InterfaceInterception;

namespace SOLIDDemo.SocialApp
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

            _container.RegisterType<IMessageReader, TwitterMessageReader>(
                new Interceptor<InterfaceInterceptor>(),
                new InterceptionBehavior<IInterceptionBehavior>());

            _container.RegisterType<IMessageWriter, FacebookMessageWriter>(
                new Interceptor<InterfaceInterceptor>(),
                new InterceptionBehavior<IInterceptionBehavior>());

            var startup = _container.Resolve<Startup>();

            startup.Run();
        }
    }
}
