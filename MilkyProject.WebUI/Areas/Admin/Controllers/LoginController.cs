using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.EntityLayer.Concrete;
using MilkyProject.WebUI.Dtos.Login;
using Newtonsoft.Json;
using System.Text;

namespace MilkyProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;

        public LoginController(IHttpClientFactory httpClientFactory, SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
        {
            _httpClientFactory = httpClientFactory;
            _signInManager = signInManager;
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(ResultLoginDto login)
        {
            var client = _httpClientFactory.CreateClient();
            var jsondata = JsonConvert.SerializeObject(login);
            var content = new StringContent(jsondata, Encoding.UTF8, "application/json");
            var resp = await client.PostAsync("https://localhost:7199/api/Login/Login", content);
            if (resp.IsSuccessStatusCode)
            {
                var user = await _userManager.FindByEmailAsync(login.Email);
                await _signInManager.PasswordSignInAsync(user, login.Password, false, false);
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                return View();
            }

        }
    }
}
