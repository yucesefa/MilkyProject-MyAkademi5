using Microsoft.AspNetCore.Mvc;
using MilkyProject.WebUI.Dtos.Member;
using Newtonsoft.Json;

namespace MilkyProject.WebUI.Areas.Admin.ViewComponents
{
    public class _DashboardMemberComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DashboardMemberComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7199/api/Member");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultMemberDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
