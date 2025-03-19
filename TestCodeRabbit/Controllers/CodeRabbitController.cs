using Microsoft.AspNetCore.Mvc;
using TestCodeRabbit.Services;

namespace TestCodeRabbit.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CodeRabbitController : ControllerBase
    {
        private ITestCodeRabbitService TEST_CODE_RABBIT;
        /// <summary>
        /// Initializes a new instance of the <see cref="CodeRabbitController"/> class.
        /// </summary>
        public CodeRabbitController(ITestCodeRabbitService testCodeRabbitService)
        {
            TEST_CODE_RABBIT = testCodeRabbitService;
        }

        /// <summary>
        /// Retrieves a rabbit object using the injected rabbit service.
        /// </summary>
        /// <remarks>
        /// This action method calls the service's GetRabbit method and returns an HTTP 200 OK response with the rabbit object if successful.
        /// If an exception is encountered, the method returns null, resulting in the default response for a null action result.
        /// </remarks>
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
