using Microsoft.AspNetCore.Mvc;
using TestCodeRabbit.Services;

namespace TestCodeRabbit.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CodeRabbitController : ControllerBase
    {
        private readonly ITestCodeRabbitService _testCodeRabbitService;
        public CodeRabbitController(ITestCodeRabbitService testCodeRabbitService)
        {
            _testCodeRabbitService = testCodeRabbitService;
        }

        [HttpGet(Name = "GetRabbit")]
        public IActionResult Get()
        {
            try
            {
                var rabbit = _testCodeRabbitService.GetRabbit();
                return Ok(rabbit);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Fuck off! " + ex.Message);
            }
        }
    }
}
