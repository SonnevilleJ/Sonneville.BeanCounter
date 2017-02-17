using System.Web.Http;

namespace OwinWebApp
{
    [RoutePrefix("api/hello")]
    public class HelloController : ApiController
    {
        [Route("{name}")]
        [HttpGet]
        public string Greet(string name = "World")
        {
            return $"Hello, {name}!";
        }
    }
}
