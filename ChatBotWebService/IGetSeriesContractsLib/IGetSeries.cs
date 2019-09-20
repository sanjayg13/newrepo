using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatBotDBAccess;

namespace IGetSeriesContractsLib
{
    public interface IGetSeries
    {
        List<string> GetSeriesType(string name);
    }
}
