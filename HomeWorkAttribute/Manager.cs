using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkAttribute
{
    [AccessLevel(1,nameof(AccesLevelType.Average))]
    internal class Manager : Employee
    {
    }
}
