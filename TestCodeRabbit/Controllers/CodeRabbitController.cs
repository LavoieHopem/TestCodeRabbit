using Microsoft.AspNetCore.Mvc;
using TestCodeRabbit.Services;

namespace TestCodeRabbit.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CodeRabbitController : ControllerBase
    {
        private ITestCodeRabbitService TEST_CODE_RABBIT;
        public CodeRabbitController(ITestCodeRabbitService testCodeRabbitService)
        {
            TEST_CODE_RABBIT = testCodeRabbitService;
        }

        [HttpGet(Name = "GetRabit")]
        public IActionResult Get()
        {
            try
            {
                var rabbit = TEST_CODE_RABBIT.GetRabbit();
                return Ok(rabbit);
            }
            catch (Exception)
            {

            }
            return null;
        }
    }
}
