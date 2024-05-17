using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.EntityLayer.Concrete;
using MilkyProject.WebUI.Dtos.Login;

namespace MilkyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [HttpPost("Login")]

        public async Task<IActionResult> Login(ResultLoginDto loginDto)
        {
            var user = await _userManager.FindByEmailAsync(loginDto.Email);
            var login = await _signInManager.PasswordSignInAsync(user.UserName, loginDto.Password, false, false);
            if (login.Succeeded)
            {
                return Ok(login);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
