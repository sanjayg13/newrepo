using ChatBotDBAccess;
using DeleteMonitorContractsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteMonitorLib
{
    public class DeleteMonitor : IDeleteMonitor
    {
        bool IDeleteMonitor.DeleteMonitor(string mod)
        {
            using (ChatBotDBEntities2 entities = new ChatBotDBEntities2())
            {
                var entity = entities.Monitors.Remove(entities.Monitors.FirstOrDefault(e => e.ModelNo == mod));
                entities.SaveChanges();
                return true;

            }
        }
    }
}
