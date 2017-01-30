using Google.Apis.Drive.v3;

namespace Sonneville.Google.Wrappers.About
{
    public interface IAboutResource
    {
        /// <summary>Gets information about the user, the user's Drive, and system capabilities.</summary>
        IGetRequest Get();

        AboutResource Impl { get; }
    }

    public class AboutResourceWrapper : IAboutResource
    {
        public AboutResourceWrapper(AboutResource impl)
        {
            Impl = impl;
        }

        public AboutResource Impl { get; }

        public IGetRequest Get()
        {
            return new GetRequestWrapper(Impl.Get());
        }
    }
}