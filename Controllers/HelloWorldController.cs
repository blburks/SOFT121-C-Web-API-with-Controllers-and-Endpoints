using Microsoft.AspNetCore.Mvc;
using FP_CSharp.Models;

namespace FP_CSharp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetMessage()
        {
            var msg = new Message("Hello, World from C# API!");
            return Ok(msg);
        }
    }
}