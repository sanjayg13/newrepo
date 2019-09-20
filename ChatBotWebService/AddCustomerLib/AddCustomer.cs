using AddCustomerContractsLib;
using ChatBotDBAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddCustomerLib
{
    public class AddCustomer : IAddCustomer
    {
        Registration IAddCustomer.AddCustomer(Registration customer)
        {
            using (ChatBotDBEntities2 entities = new ChatBotDBEntities2())
            {
                var entity = entities.Registrations.Add(customer);
                entities.SaveChanges();
                return entity;

            }
        }
    }
}
