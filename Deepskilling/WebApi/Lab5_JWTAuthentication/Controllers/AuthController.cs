using Microsoft.AspNetCore.Mvc;

namespace Lab5_JWTAuthentication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpGet]
        public IActionResult GenerateToken()
        {
            string token = "Dummy-JWT-Token";

            return Ok(token);
        }
    }
}