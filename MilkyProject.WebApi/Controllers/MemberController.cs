using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinessLayer.Abstract;

namespace MilkyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly IMemberService _memberService;

        public MemberController(IMemberService memberService)
        {
            _memberService = memberService;
        }
        [HttpGet]
        public IActionResult GetMemberList()
        {
            var values = _memberService.TGetListAll();
            return Ok(values);
        }
        [HttpGet("GetMemberCount")]
        public IActionResult GetMemberCount()
        {
            return Ok(_memberService.TGetMemberCount());
        }
    }
}
