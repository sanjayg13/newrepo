using ChatBotDBAccess;
using GetMonitorOnPortabilityContractsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMonitorOnPortabilityLib
{
    public class GetMonitorOnPortability : IGetMonitorOnPortability
    {
        List<string> IGetMonitorOnPortability.GetMonitorOnPortability(string portability)
        {
            using (ChatBotDBEntities2 entities = new ChatBotDBEntities2())
            {
                return (entities.Monitors.Where(e => e.Spec1.ToLower() == portability.ToLower()).Select(Column => Column.ModelNo).ToList());
            }
        }
    }
}
