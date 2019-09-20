using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatBotDBAccess;

namespace AddCustomerContractsLib
{
    public interface IAddCustomer
    {
        Registration AddCustomer(Registration customer);  
    }
}
