using System;
using Microsoft.Owin.Hosting;
using Ninject.Extensions.Conventions;
using Ninject.Modules;
using Sonneville.BeanCounter.OwinWebApp.SelfHost;

namespace Sonneville.BeanCounter.OwinWebApp.DependencyInjection
{
    public class AppModule : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind(syntax => syntax.FromAssembliesMatching("Sonneville.*")
                .SelectAllClasses()
                .BindAllInterfaces()
                .Configure(configurationAction => configurationAction.InSingletonScope()));

            BindApp();
        }

        private void BindApp()
        {
            Func<string, IDisposable> starter = WebApp.Start<Startup>;
            Bind<Func<string, IDisposable>>().ToConstant(starter).WhenInjectedInto<IApp>();

            const string hostname = "localhost";
            const string port = "80";
            var bindAddress = $"http://{hostname}:{port}/";
            Bind<string>().ToConstant(bindAddress).WhenInjectedInto<IApp>();
        }
    }
}
