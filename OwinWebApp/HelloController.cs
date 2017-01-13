using System.Web.Http;

namespace OwinWebApp
{
    public class HelloController : ApiController
    {
        public string Get(string id = "World")
        {
            return $"Hello, {id}!";
        }
    }
}
