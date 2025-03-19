using TestCodeRabbit.Models;

namespace TestCodeRabbit.Services
{
    public class TestCodeRabbitService : ITestCodeRabbitService
    {
        /// <summary>
        /// Creates and returns a new instance of RabbitDto with preset test values.
        /// </summary>
        /// <returns>
        /// A RabbitDto object where CreatedDate is set to the current date and time, CountElement is set to 2, and Name is set to "Test en prod".
        /// </returns>
        public RabbitDto GetRabbit()
        {
            return new RabbitDto
            {
                CreatedDate = DateTime.Now,
                CountElement = 2,
                Name = "Test en prod"
            };
        }

        /// <summary>
        /// Retrieves a collection of rabbit data transfer objects.
        /// </summary>
        /// <remarks>
        /// This method is not yet implemented and always throws a NotImplementedException.
        /// </remarks>
        public IList<RabbitDto> GetRabbits()
        {
            throw new NotImplementedException();
        }
    }
}
