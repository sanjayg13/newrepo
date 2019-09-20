using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMonitorOnPortabilitySizeContractsLib
{
    public interface IGetMonitorOnPortabilitySize
    {
        List<string> GetPortabilitySize(string portability, string size);
    }
}
