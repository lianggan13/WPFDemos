using Microsoft.AspNetCore.Mvc;

namespace SmartParking.Server.Start.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        [Route("login")]
        public string Login()
        {
            return "{username}:{password}";
        }

        [HttpPost]
        [Route("login")]
        public string Login([FromForm] string username, [FromForm] string password)
        {
            return $"{username}:{password}";
        }
    }
}
