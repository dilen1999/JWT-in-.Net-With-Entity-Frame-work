using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWT.Controllers
{
    [Authorize]
    [Route("api/[controller]")]

    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public async Task<string> test()
        {
            return  "hit me";
        }
    }
}
