using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatBotDBAccess;
using IGetSeriesContractsLib;

namespace GetSeriesLib
{
    public class GetSeriesType : IGetSeries
    {
        

        List<string> IGetSeries.GetSeriesType(string name)
        {
           
            using (ChatBotDBEntities2 entities = new ChatBotDBEntities2())
            { return entities.Monitors.Where(e => e.SeriesName.ToLower() == name.ToLower()).Select(Column => Column.ModelNo).ToList(); }
        }
    }
}
