using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinessLayer.Abstract;
using MilkyProject.EntityLayer.Concrete;

namespace MilkyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GalleryController : ControllerBase
    {
        private readonly IGalleryService _galleryService;

        public GalleryController(IGalleryService galleryService)
        {
            _galleryService = galleryService;
        }
        [HttpGet]
        public IActionResult GetGalleryList()
        {
            var values = _galleryService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateGallery(Gallery gallery)
        {
            _galleryService.TInsert(gallery);
            return Ok("basarılı ");
        }
        [HttpDelete]
        public IActionResult DeleteGallery(int id)
        {
            _galleryService.TDelete(id);
            return Ok("basarı ile siindi");
        }
        [HttpGet("GetGallery")]
        public IActionResult GetGallery(int id)
        {
            var values = _galleryService.TGetById(id);
            return Ok(values);

        }
        [HttpPut]
        public IActionResult UpdateGallery(Gallery gallery)
        {
            _galleryService.TUpdate(gallery);
            return Ok("basarı ile güncellendi");
        }
    }
}
