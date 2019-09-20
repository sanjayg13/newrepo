using ChatBotDBAccess;
using DeleteCustomerContractsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteCustomerLib
{
    public class DeleteCustomer : IDeleteCustomer
    {
        bool IDeleteCustomer.DeleteCustomer(int id)
        {
            using (ChatBotDBEntities2 entities = new ChatBotDBEntities2())
            {
                 var entity = entities.Registrations.Remove(entities.Registrations.FirstOrDefault(e => e.Id == id));
                 entities.SaveChanges();
                return true;
                
            }
        }
    }
}
