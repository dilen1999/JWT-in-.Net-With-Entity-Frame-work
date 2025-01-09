using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JWT.Controllers
{
    [Authorize]
    [Route("api/[controller]")]

    [ApiController]
    public class HomeTestController : Controller
    {
       
            [HttpGet]
            public IActionResult HomeTest() 
            {
                return Ok("hit me111");
            }
        
    }
}
