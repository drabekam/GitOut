using Microsoft.AspNetCore.Mvc;
using System;

namespace GitOut.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GitOutController : ControllerBase
    {
        private readonly ILogger<GitOutController> _logger;

        public GitOutController(ILogger<GitOutController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetMyName")]
        public IActionResult GetMyName()
        {
           
            var myName = "Andrew Drabek";

            return Ok(new { Name = myName });
        }
    }
}
