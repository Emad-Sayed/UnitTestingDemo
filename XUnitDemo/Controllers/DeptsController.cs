using Core.Infrastructure.Repository.Entities;
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
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Todo
        ///     {
        ///        "Name": "Computer Science",
        ///     }
        ///
        /// </remarks>
        /// <param name="model"></param>
        /// <returns>A newly created Departement</returns>
        /// <response code="200">Returns the newly created item</response>
        /// <response code="400">If the item is null</response>  
        [HttpPost]
        public ActionResult Create([FromBody] CreateDept model)
        {
            var Rs = _service.Create(model);
            return Ok(Rs);
        }
        /// <summary>
        ///  returns all Departements with pagination default pageSize 10 and default pageNumber 1
        /// </summary>
        [HttpGet]
        [ProducesResponseType(typeof(List<Departement>), 200)]
        public ActionResult GetAll([FromQuery] Search search)
        {
            var Rs = _service.GetAll(search);
            return Ok(Rs);
        }
        /// <response code="200">Returns the newly created item</response>
        /// <response code="400">If the item is null</response> 
        [ProducesResponseType(typeof(Departement), 200)]
        [ProducesResponseType(typeof(string), 400)]
        [HttpGet("GetById")]
        public ActionResult GetById([FromQuery] int id)
        {
            var Rs = _service.GetById(id);
            if (!Rs.status)
                return BadRequest("no data founded");
            return Ok(Rs);
        }
    }
}
