using ChatBotDBAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateCustomerConstractsLib
{
    public interface IUpdateMonitor
    {
        Registration UpdateCustomer(int id ,Registration customer);
    }
}
