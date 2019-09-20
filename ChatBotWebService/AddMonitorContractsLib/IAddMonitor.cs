using ChatBotDBAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddMonitorContractsLib
{
    public interface IAddMonitor
    {
        Monitor AddMonitor(Monitor model);
    }
}
