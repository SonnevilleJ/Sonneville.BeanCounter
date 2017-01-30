namespace Sonneville.Google.Wrappers.About
{
    public interface IAboutResource
    {
        /// <summary>Gets information about the user, the user's Drive, and system capabilities.</summary>
        IGetRequest Get();
    }
}