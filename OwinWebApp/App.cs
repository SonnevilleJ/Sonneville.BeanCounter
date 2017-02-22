using System;
using System.Collections.Generic;
using Sonneville.Utilities.Sleepers;

namespace Sonneville.BeanCounter.OwinWebApp
{
    public interface IApp : IDisposable
    {
        void Run(IEnumerable<string> args);
    }

    public class App : IApp
    {
        private readonly Func<string, IDisposable> _starter;
        private readonly string _bindingUrl;
        private readonly ISleepUtil _sleepUtil;

        public App(Func<string, IDisposable> starter, string bindingUrl, ISleepUtil sleepUtil)
        {
            _starter = starter;
            _bindingUrl = bindingUrl;
            _sleepUtil = sleepUtil;
        }

        public void Run(IEnumerable<string> args)
        {
            using (_starter.Invoke(_bindingUrl))
            {
                Console.WriteLine($"Listening on {_bindingUrl}");
                _sleepUtil.WaitForExitSignal();
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
            }
        }
    }
}
