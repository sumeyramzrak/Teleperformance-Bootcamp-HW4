using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Teleperformance.Odev4.Services.Abstractions;

namespace Teleperformance.Odev4.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class UsersController : ControllerBase
    {
        private readonly IUserService service;

        public UsersController(IUserService service) 
        {
            this.service = service;
        }

        [HttpGet("list")]
        public IActionResult GetAllUsers() // Kullanýcýlarý listele
        {
            var result = service.GetAllUsers();
            return Ok(result);
        }
    }
}