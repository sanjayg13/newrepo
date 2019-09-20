using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMonitorOnSizeContractsLib
{
    public interface IGetMonitorOnSize
    {
         List<string> GetMonitorOnSize(string size);
    }
}
