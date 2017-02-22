using Moq;
using NUnit.Framework;
using Sonneville.BeanCounter.OwinWebApp;

namespace Sonneville.BeanCounter.OwinWebAppTest
{
    [TestFixture]
    public class ProgramTests
    {
        private Mock<IApp> _appMock;
        private string[] _cliArgs;

        [SetUp]
        public void Setup()
        {
            _cliArgs = new[] { "1", "2", "3" };

            _appMock = new Mock<IApp>();

            Program.Kernel.Rebind<IApp>().ToConstant(_appMock.Object);
        }

        [Test]
        public void ShouldPassArgumentsToApp()
        {
            Program.Main(_cliArgs);

            _appMock.Verify(app => app.Run(_cliArgs), Times.Once());
            _appMock.Verify(app => app.Dispose(), Times.Once());
        }
    }
}
