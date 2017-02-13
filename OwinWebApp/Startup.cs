using System.Web.Http;
using Microsoft.Owin.FileSystems;
using Microsoft.Owin.StaticFiles;
using Owin;

namespace OwinWebApp
{
    public sealed class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            ConfigureApiHosting(appBuilder);
            ConfigureStaticHosting(appBuilder);
        }

        private static void ConfigureApiHosting(IAppBuilder appBuilder)
        {
            var config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new {id = RouteParameter.Optional}
            );
            appBuilder.UseWebApi(config);
        }

        private static void ConfigureStaticHosting(IAppBuilder appBuilder)
        {
            var options = new FileServerOptions
            {
                FileSystem = new PhysicalFileSystem("Resources"),
            };
            appBuilder.UseFileServer(options);
        }
    }
}
