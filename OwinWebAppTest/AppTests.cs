using System;
using Moq;
using NUnit.Framework;
using Sonneville.BeanCounter.OwinWebApp;
using Sonneville.Utilities.Sleepers;

namespace Sonneville.BeanCounter.OwinWebAppTest
{
    [TestFixture]
    public class AppTests
    {
        private App _app;
        private Mock<IDisposable> _webAppMock;
        private string _url;
        private Func<string, IDisposable> _starter;
        private Mock<ISleepUtil> _sleepUtilMock;

        [SetUp]
        public void Setup()
        {
            _webAppMock = new Mock<IDisposable>();
            _url = "url";

            _starter = url =>
            {
                Assert.AreEqual(_url, url);
                return _webAppMock.Object;
            };

            _sleepUtilMock = new Mock<ISleepUtil>();

            _app = new App(_starter, _url, _sleepUtilMock.Object);
        }

        [Test]
        public void ShouldDispose()
        {
            _app.Run(null);

            _webAppMock.Verify(webApp => webApp.Dispose());
        }

        [Test]
        public void ShouldDisposeWebAppAfterSleepReturns()
        {
            _sleepUtilMock.Setup(sleepUtil => sleepUtil.WaitForExitSignal())
                .Callback(() => _webAppMock.Verify(webApp => webApp.Dispose(), Times.Never));

            _app.Run(null);

            _sleepUtilMock.Verify(sleepUtil => sleepUtil.WaitForExitSignal());
            _webAppMock.Verify(webApp => webApp.Dispose());
        }
    }
}
