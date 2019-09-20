using ChatBotDBAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteCustomerContractsLib
{
    public interface IDeleteCustomer
    {
        bool  DeleteCustomer(int id);
    }
}
