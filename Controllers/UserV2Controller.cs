using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersioningTest.Controllers
{
    //Route for Query string parameter versioning
    //[Route("api/user/[action]")]
    //Route for URI versioning
    [Route("api/v{version:apiVersion}/user/[action]")]
    [ApiController]
    [ApiVersion("2")]
    public class UserV2Controller : ControllerBase
    {
        [HttpGet]
        public ActionResult GetInfo() 
        {
            return Ok("User V2 Controller");
        }
    }
}
