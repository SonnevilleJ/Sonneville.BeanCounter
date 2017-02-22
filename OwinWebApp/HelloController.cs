using System.Web.Http;

namespace Sonneville.BeanCounter.OwinWebApp
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
