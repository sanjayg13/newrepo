using ChatBotDBAccess;
using GetAllCategoriesContractsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetAllCategoriesLib
{
    public class GetAllCategories : IGetAllCategories
    {
        List<string> IGetAllCategories.GetAllCategories()
        {
            using (ChatBotDBEntities2 entities = new ChatBotDBEntities2())
            {
                return (entities.Monitors.Select(Column => Column.Category).Distinct().ToList());
            }
        }
    }
}
