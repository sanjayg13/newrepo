using ChatBotDBAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateMonitorContractsLib
{
    public interface IUpdateMonitor
    {
        Monitor UpdateMonitor(string mod, Monitor model);
    }
}
