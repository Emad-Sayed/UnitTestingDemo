using Core.Infrastructure.Services;
using Core.Infrastructure.Services.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XUnitDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeptsController : ControllerBase
    {
        public readonly IDeptService _service;
        public DeptsController(IDeptService service)
        {
            _service = service;
        }
        [HttpPost]
        public ActionResult Create([FromBody] CreateDept model)
        {
            var Rs = _service.Create(model);
            return Ok(Rs);
        }
        [HttpGet]
        public ActionResult GetAll([FromQuery] Search search)
        {
            var Rs = _service.GetAll(search);
            return Ok(Rs);
        }
        [HttpGet("GetById")]
        public ActionResult GetById([FromQuery] int id)
        {
            var Rs = _service.GetById(id);
            return Ok(Rs);
        }
    }
}
