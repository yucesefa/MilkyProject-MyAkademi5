﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinessLayer.Abstract;
using MilkyProject.EntityLayer.Concrete;

namespace MilkyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }
        [HttpGet]
        public IActionResult GetServiceList()
        {
            var values = _serviceService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateService(Service service)
        {
            _serviceService.TInsert(service);
            return Ok("Basarılı");

        }
        [HttpDelete]
        public IActionResult DeleteService(int id)
        {
            _serviceService.TDelete(id);
            return Ok("Hizmet başarıyla silindi");
        }
        [HttpPut]
        public IActionResult UpdateService(Service service)
        {
            _serviceService.TUpdate(service);
            return Ok("Kategori başarıyla güncellendi");
        }
        [HttpGet("GetService")]
        public IActionResult GetService(int id)
        {
            var values = _serviceService.TGetById(id);
            return Ok(values);
        }
    }
}
