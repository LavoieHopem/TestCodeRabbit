using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCodeRabbit.Models;

namespace TestCodeRabbit.Services
{
    public interface ITestCodeRabbitService
    {
        /// <summary>
/// Retrieves a single RabbitDto instance.
/// </summary>
/// <returns>An instance of RabbitDto representing rabbit data.</returns>
RabbitDto GetRabbit();
        /// <summary>
/// Retrieves a list of RabbitDto objects.
/// </summary>
/// <returns>A list of RabbitDto instances.</returns>
IList<RabbitDto> GetRabbits();
    }
}
