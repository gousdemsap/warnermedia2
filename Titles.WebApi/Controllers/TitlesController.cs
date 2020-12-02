using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Titles.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TitlesController : ControllerBase
    {
        
        private readonly ILogger<TitlesController> _logger;

        public TitlesController(ILogger<TitlesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("My first API");
        }
    }
}
