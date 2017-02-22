using Ninject;
using Sonneville.BeanCounter.OwinWebApp.DependencyInjection;

namespace Sonneville.BeanCounter.OwinWebApp
{
    public static class Program
    {
        public static readonly IKernel Kernel = new KernelBuilder().Build();

        public static void Main(string[] args)
        {
            using (var app = Kernel.Get<IApp>())
            {
                app.Run(args);
            }
        }
    }
}
