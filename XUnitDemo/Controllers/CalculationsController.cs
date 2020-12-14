using Core.Infrastructure;
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
    public class CalculationsController : ControllerBase
    {
        private readonly ICalculation calcs_;
        public CalculationsController(ICalculation calcs)
        {
            calcs_ = calcs;
        }
        [HttpGet("Calculate1")]
        public ActionResult Calculate1([FromQuery]string word)
        {
            var result = calcs_.Calculate1(word);
            return Ok(result);
        }
    }
}
