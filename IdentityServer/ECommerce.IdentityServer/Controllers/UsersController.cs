using ECommerce.IdentityServer.Dtos;
using ECommerce.IdentityServer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ECommerce.IdentityServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
       
        private readonly UserManager<ApplicationUser> _userManager;

        public UsersController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpPost("register")]
        public async Task<IActionResult>Register(RegisterDto model)
        {
            var user = new ApplicationUser
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                UserName = model.UserName,
              
            };
            var result=await _userManager.CreateAsync(user,model.Password);

            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }
            return Ok("kullanıcı kaydı başarılı");

        }
    }
}

//postmanda kullanıcı olusturma
//{
//    "firstName": "Münevver",
//  "lastName": "Orman",
//  "userName": "munevverorman",
//  "email": "munevverorman@gmail.com",
//  "password": "Password12*"
//}