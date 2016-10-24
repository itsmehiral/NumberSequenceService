using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;

namespace NumberSeqenceWeb.Tests
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            //container.RegisterType<IServiceManager, ServiceManager>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}