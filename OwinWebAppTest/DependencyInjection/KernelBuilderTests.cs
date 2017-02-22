using Ninject;
using NUnit.Framework;
using Sonneville.BeanCounter.OwinWebApp;
using Sonneville.BeanCounter.OwinWebApp.DependencyInjection;

namespace Sonneville.BeanCounter.OwinWebAppTest.DependencyInjection
{
    [TestFixture]
    public class KernelBuilderTests
    {
        private IKernel _kernel;

        [SetUp]
        public void Setup()
        {
            _kernel = new KernelBuilder().Build();
        }

        [TearDown]
        public void TearDown()
        {
            _kernel?.Dispose();
        }

        [Test]
        public void ShouldGetApp()
        {
            using (var app = _kernel.Get<IApp>())
            {
                Assert.IsNotNull(app);
                Assert.IsAssignableFrom<App>(app);
            }
        }
    }
}