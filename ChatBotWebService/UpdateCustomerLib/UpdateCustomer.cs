using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatBotDBAccess;
using UpdateCustomerConstractsLib;

namespace UpdateCustomerLib
{
    public class UpdateCustomer : IUpdateMonitor
    {
        Registration IUpdateMonitor.UpdateCustomer(int id, Registration customer)
        {
            using (ChatBotDBEntities2 entities = new ChatBotDBEntities2())
            {

                var entity = entities.Registrations.FirstOrDefault(e => e.Id == id);



                entity.Name = customer.Name;
                entity.City = customer.City;
                entity.Contact = customer.Contact;
                entity.Mail = customer.Mail;
                entity.Model = customer.Model;
                entities.SaveChanges();
                return entity;

            }
        }
    }
}