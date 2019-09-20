using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ChatBotDBAccess;

namespace EmployeeWebAPI.Controllers
{
    public class SolutionController : ApiController
    {

        [Route("api/Solution/GetSolutionType/{category}")]
        [HttpGet]
        //Get all solutions under a type
        public HttpResponseMessage GetSolutionType(string category = "all")

        {
            try
            {
                using (ChatBotDBEntities2 entities = new ChatBotDBEntities2())

                {
                    return Request.CreateResponse(HttpStatusCode.OK, entities.Solutions.Where(e => e.Category
                    .ToLower() == category.ToLower()).Select(Column => Column.Name).ToList());
                }
            }



            catch (Exception ex)
            { return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex); }
        }

        //-----------------------------------------------------------------------------------------------------------//

        [Route("api/Solution/GetSolution/{name}")]
        [HttpGet]
        //Get all details of a particular solution
        public HttpResponseMessage GetSolution(string name = "all")

        {
            try
            {
                using (ChatBotDBEntities2 entities = new ChatBotDBEntities2())

                {
                    return Request.CreateResponse(HttpStatusCode.OK, entities.Solutions.Where(e => e.Name
                    .ToLower() == name.ToLower()).ToList());
                }
            }



            catch (Exception ex)
            { return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex); }
        }

        //-----------------------------------------------------------------------------------------------------------------

        [Route("api/Solution/GetAllSolutionTypes")]
        [HttpGet]
        //Get all distinct type of a solutions
        public HttpResponseMessage GetAllSolutionTypes()

        {
            try
            {
                using (ChatBotDBEntities2 entities = new ChatBotDBEntities2())

                {
                    return Request.CreateResponse(HttpStatusCode.OK, entities.Solutions.Select(Column => Column.Category).Distinct().ToList());
                }
            }

            catch (Exception ex)
            { return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex); }
        }



    }
}
