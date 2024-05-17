using Microsoft.AspNetCore.Mvc;

namespace MilkyProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DashboardController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index()
        {
            var clientContact = _httpClientFactory.CreateClient();
            var responseMessageContact = await clientContact.GetAsync("https://localhost:7199/api/Contact/GetContactCount");

            var clientMember = _httpClientFactory.CreateClient();
            var responseMessageMember = await clientContact.GetAsync("https://localhost:7199/api/Member/GetMemberCount");

            var clientCategory = _httpClientFactory.CreateClient();
            var responseMessageCategory = await clientContact.GetAsync("https://localhost:7199/api/Category/GetCategoryCount");

            var clientProduct = _httpClientFactory.CreateClient();
            var responseMessageProduct = await clientContact.GetAsync("https://localhost:7199/api/Product/GetProductCount");

            if(responseMessageContact.IsSuccessStatusCode)
            {
                var jsonDataContact = await responseMessageContact.Content.ReadAsStringAsync();
                ViewBag.Contact=jsonDataContact;
                
                var jsonDataMember = await responseMessageMember.Content.ReadAsStringAsync();
                ViewBag.Member=jsonDataMember;

                var jsonDataCategory = await responseMessageCategory.Content.ReadAsStringAsync();
                ViewBag.Category=jsonDataCategory;

                var jsonDataProduct = await responseMessageProduct.Content.ReadAsStringAsync();
                ViewBag.Product=jsonDataProduct;

                return View();
            }

            return View();
        }
    }
}
