using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ChatBotDBAccess;
using Unity;

namespace EmployeeWebAPI.Controllers
{
    public class CustomerController : ApiController
    {
        UnityContainer _con = new UnityContainer();
        public AddCustomerContractsLib.IAddCustomer _addcustomer;
        public UpdateCustomerConstractsLib.IUpdateMonitor _updatecustomer;
        public DeleteCustomerContractsLib.IDeleteCustomer _deletecustomer;

        public CustomerController()
        {
            _con.RegisterType<AddCustomerContractsLib.IAddCustomer, AddCustomerLib.AddCustomer>();
            _con.RegisterType<UpdateCustomerConstractsLib.IUpdateMonitor, UpdateCustomerLib.UpdateCustomer>();
            _con.RegisterType<DeleteCustomerContractsLib.IDeleteCustomer, DeleteCustomerLib.DeleteCustomer>();

        }

        //CRUD fucntion implementations

        [Route("api/Customer/register")]
        [HttpPost]//Adding customer details

        public HttpResponseMessage Post([FromBody] Registration customer)

        {
            _addcustomer = _con.Resolve<AddCustomerContractsLib.IAddCustomer>();
            var entity = _addcustomer.AddCustomer(customer);

            if (entity == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Customer is not added");
            }
            else
            {

                return Request.CreateResponse(HttpStatusCode.OK, "Customer has been added successfully ");

            }
        }
        //----------------------------------------------------------------------------------------------------------------
        [Route("api/Customer/update/{id}")]
        [HttpPut]// Update Customer details
        public HttpResponseMessage Put(int id, [FromBody]Registration customer)
        {
            _updatecustomer = _con.Resolve<UpdateCustomerConstractsLib.IUpdateMonitor>();
            var entity = _updatecustomer.UpdateCustomer(id, customer);

            if (entity == null)
            { return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Customer with ID" + id + "Is not found"); }

            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Customer details successfully updated ");
            }

        }


        //----------------------------------------------------------------------------------------------------------------------------



        [Route("api/Customer/delete/{id}")]

        public HttpResponseMessage Delete(int id)
        {
            _deletecustomer = _con.Resolve<DeleteCustomerContractsLib.IDeleteCustomer>();
            var entity = _deletecustomer.DeleteCustomer(id);

            if (!entity)
            { return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Customer with ID" + id + "Is not found"); }

            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Customer details deleted successfully ");
            }

        }
    }
}

