using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteMonitorContractsLib
{
    public interface IDeleteMonitor
    {
        bool DeleteMonitor(string mod);
    }
}
