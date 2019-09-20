using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMonitorOnPortabilityContractsLib
{
    public interface IGetMonitorOnPortability
    {
        List<string> GetMonitorOnPortability(string portability);
    }
}
