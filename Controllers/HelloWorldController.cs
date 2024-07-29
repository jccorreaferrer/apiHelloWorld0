using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apiHelloWorld0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet(Name = "HelloWorld")]
        public String Get()
        {
            return  "To everybody, Hello World!";
        }
    }
}
