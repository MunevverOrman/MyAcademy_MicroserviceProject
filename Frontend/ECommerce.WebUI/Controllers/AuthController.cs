using ECommerce.WebUI.DTOs.IdentityServerDtos;
using ECommerce.WebUI.Services.IdentityServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebUI.Controllers
{
    [Authorize]

    public class AuthController(IIdentityService _ıdentityService) : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginDto loginDto)
        
        { 
            var result= await _ıdentityService.LoginAsync(loginDto);
            if (!result)
            {
                ModelState.AddModelError("", "Kullanıcı adı veya şifre hatalı");
                return View();
            }
            return Redirect("/Admin/Category/Index");
        
        }
    }
}
