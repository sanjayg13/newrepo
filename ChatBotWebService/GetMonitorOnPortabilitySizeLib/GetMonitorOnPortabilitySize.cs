using ChatBotDBAccess;
using GetMonitorOnPortabilitySizeContractsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMonitorOnPortabilitySizeLib
{
    public class GetMonitorOnPortabilitySize : IGetMonitorOnPortabilitySize
    {
        public List<string> GetPortabilitySize(string portability, string size)
        {
            //string p = portability, s = size;
            if (portability.ToLower() != "portable")
            {
                portability = size;
                size = portability;
            }

            using (ChatBotDBEntities2 entities = new ChatBotDBEntities2())
            {
                return ( entities.Monitors.Where(e => e.Spec2.ToLower() == size.ToLower())
                                                                                  .Where(e => e.Spec1.ToLower() == portability.ToLower()).Select(Column => Column.ModelNo).ToList());
            }
        }
    }
}
