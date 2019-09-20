using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatBotDBAccess;
using UpdateMonitorContractsLib;

namespace UpdateMonitorLib
{
    public class UpdateMonitor : IUpdateMonitor
    {
        

        Monitor IUpdateMonitor.UpdateMonitor(string mod, Monitor model)
        {
            using (ChatBotDBEntities2 entities = new ChatBotDBEntities2())
            {

                var entity = entities.Monitors.FirstOrDefault(e => e.ModelNo == mod);
                entity.SeriesName = model.SeriesName;
                entity.ModelNo = model.ModelNo;
                entity.Spec1 = model.Spec1;
                entity.Spec2 = model.Spec2;
                entity.Spec3 = model.Spec3;
                entity.url = model.url;
                entities.SaveChanges();
                return entity;


            }
        }
    }
}
