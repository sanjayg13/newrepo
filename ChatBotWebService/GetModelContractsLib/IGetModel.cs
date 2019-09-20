using ChatBotDBAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetModelContractsLib
{
    public interface IGetModel
    {
        List<Monitor> GetModel(string name);
    }
}
