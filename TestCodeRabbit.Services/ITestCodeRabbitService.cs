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
        RabbitDto GetRabbit();
        IList<RabbitDto> GetRabbits();
    }
}
