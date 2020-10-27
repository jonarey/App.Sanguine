using Microsoft.AspNetCore.Mvc;

namespace App.Sanguine.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public int Get()
        {
            return 200;
        }
    }
}
