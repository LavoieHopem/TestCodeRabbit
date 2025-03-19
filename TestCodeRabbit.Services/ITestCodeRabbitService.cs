using TestCodeRabbit.Models;

namespace TestCodeRabbit.Services
{
    public interface ITestCodeRabbitService
    {
        RabbitDto GetRabbit();
        IList<RabbitDto> GetRabbits();
    }
}
