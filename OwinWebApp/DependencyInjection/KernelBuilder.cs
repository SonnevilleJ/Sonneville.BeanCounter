using Ninject;

namespace Sonneville.BeanCounter.OwinWebApp.DependencyInjection
{
    public class KernelBuilder
    {
        public IKernel Build()
        {
            return new StandardKernel(
                new AppModule()
            );
        } 
    }
}