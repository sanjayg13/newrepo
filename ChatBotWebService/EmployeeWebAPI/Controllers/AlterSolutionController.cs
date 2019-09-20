using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ChatBotDBAccess;

namespace EmployeeWebAPI.Controllers
{
    public class AlterSolutionController : ApiController
    {

        //CRUD fucntion implementations

        [Route("api/AlterSolution/register")]
        [HttpPost]//Adding solution

        public void Post([FromBody] Solution product)
        {
            using (ChatBotDBEntities2 entities = new ChatBotDBEntities2())
            {
                entities.Solutions.Add(product);
                entities.SaveChanges();
            }
        }

        //------------------------------------------------------------------------------------------------------------

        [Route("api/AlterSolution/update/{sol}")]
        [HttpPut]// Update a model and specs
        public HttpResponseMessage Put(string sol, [FromBody] Solution product)
        {
            try
            {
                using (ChatBotDBEntities2 entities = new ChatBotDBEntities2())
                {

                    var entity = entities.Solutions.FirstOrDefault(e => e.Name == sol);
                    if (entity == null)
                    { return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Device with ID" + sol.ToString() + "Is not found"); }

                    else
                    {
                        entity.Name = product.Name;
                        entity.Category = product.Category;
                        entity.Spec1 = product.Spec1;
                        entity.Spec3 = product.Spec3;
                        entity.url = product.url;
                        entity.Description = product.Description;
                        entities.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK, entity);
                    }

                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }


        }
        //------------------------------------------------------------------------------------------------
        [Route("api/AlterSolution/delete/{sol}")]

        public void Delete(string sol)
        {

            using (ChatBotDBEntities2 entities = new ChatBotDBEntities2())
            {
                entities.Solutions.Remove(entities.Solutions.FirstOrDefault(e => e.Name == sol));
                entities.SaveChanges();
            }


        }
    }
}
