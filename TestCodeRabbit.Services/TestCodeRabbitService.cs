using TestCodeRabbit.Models;

namespace TestCodeRabbit.Services
{
    public class TestCodeRabbitService : ITestCodeRabbitService
    {
        public RabbitDto GetRabbit()
        {
            return new RabbitDto
            {
                CreatedDate = DateTime.Now,
                CountElement = 2,
                Name = "Test en prod"
            };
        }

        public IList<RabbitDto> GetRabbits()
        {
            throw new NotImplementedException();
        }
    }
}
