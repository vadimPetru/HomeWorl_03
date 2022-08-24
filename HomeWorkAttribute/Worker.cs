using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkAttribute
{
    [AccessLevel(2,nameof(AccesLevelType.Low))]
    internal class Worker : Employee
    {
    }
}
