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
    public class AlterMonitorController : ApiController

    {
        UnityContainer _con = new UnityContainer();
        public AddMonitorContractsLib.IAddMonitor _addmonitor;
        public UpdateMonitorContractsLib.IUpdateMonitor _updatemonitor;
        public DeleteMonitorContractsLib.IDeleteMonitor _deletemonitor;

        public AlterMonitorController()
        {
            _con.RegisterType<AddMonitorContractsLib.IAddMonitor,AddMonitorLib.AddMonitor>();
            _con.RegisterType<UpdateMonitorContractsLib.IUpdateMonitor, UpdateMonitorLib.UpdateMonitor>();
            _con.RegisterType<DeleteMonitorContractsLib.IDeleteMonitor,DeleteMonitorLib.DeleteMonitor>();

        }
        //CRUD fucntion implementations

        [Route("api/AlterMonitor/register")]
        [HttpPost]//Adding

        public HttpResponseMessage Post([FromBody] Monitor model)
        {
            _addmonitor = _con.Resolve<AddMonitorContractsLib.IAddMonitor>();
            var entity = _addmonitor.AddMonitor(model);

            if (entity == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "new Model is not added");
            }
            else
            {

                return Request.CreateResponse(HttpStatusCode.OK, "new Model has been added successfully ");

            }
        }
        //---------------------------------------------------DONE---------------------------------------------------------

        [Route("api/AlterMonitor/update/{mod}")]
        [HttpPut]// Update a model and specs
        public HttpResponseMessage Put(string mod, [FromBody] Monitor model)
        {
                _updatemonitor = _con.Resolve<UpdateMonitorContractsLib.IUpdateMonitor>();
                var entity = _updatemonitor.UpdateMonitor(mod, model);

                if (entity == null)
                { return Request.CreateErrorResponse(HttpStatusCode.NotFound, "model" + mod + "Is not found"); }

                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "models details successfully updated ");
                }

            }
            

        //-----------------------------------------DONE-----------------------------------------------------------------

        [Route("api/AlterMonitor/delete/{mod}")]

        public HttpResponseMessage Delete(string mod)
        {

            _deletemonitor = _con.Resolve<DeleteMonitorContractsLib.IDeleteMonitor>();
            var entity = _deletemonitor.DeleteMonitor(mod);

            if (!entity)
            { return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Monitor " + mod.ToString() + "Is not found"); }

            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Monitor successfully deleted ");
            }

        }

    }
}
