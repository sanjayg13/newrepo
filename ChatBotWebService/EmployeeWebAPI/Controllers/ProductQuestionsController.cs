using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ChatBotDBAccess;
using Unity;
using ProductQuestionContractsLib;
using ProductQuestionLib;

namespace EmployeeWebAPI.Controllers
{
    public class ProductQuestionsController : ApiController
    {
        UnityContainer _con = new UnityContainer();
        public ProductQuestionContractsLib.IProductQuestions _getproductquestion;

        public ProductQuestionsController()
        {
            _con.RegisterType<ProductQuestionContractsLib.IProductQuestions, ProductQuestionLib.ProductQuestion>();

        }

    //-------------------------------------------DONE--------------------------------------------------


    [Route("api/ProductQuestions/GetQuestions/{question}")]
        [HttpGet]
        public HttpResponseMessage GetQuestions(string question = "all")

        {
            _getproductquestion = _con.Resolve<ProductQuestionContractsLib.IProductQuestions>();

            try
            {
                using (ChatBotDBEntities2 entities = new ChatBotDBEntities2())

                {
                    return Request.CreateResponse(HttpStatusCode.OK, _getproductquestion.GetProductQuestion(question));
                }
            }



            catch (Exception ex)
            { return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex); }
        }




    }
}
