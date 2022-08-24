using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkAttribute
{
    [AccessLevel(0,nameof(AccesLevelType.High))]
    internal class Director : Employee
    {
    }
}
