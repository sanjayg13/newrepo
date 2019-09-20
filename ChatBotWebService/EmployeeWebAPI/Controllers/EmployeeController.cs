using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ChatBotDBAccess;
using Unity;


namespace EmployeeWebAPI.Controllers
{
    public class MonitorController : ApiController
    {
        UnityContainer _con = new UnityContainer();
        public IGetSeriesContractsLib.IGetSeries _getseries;
        public GetModelContractsLib.IGetModel _getmodel;
        public GetMonitorOnPortabilitySizeContractsLib.IGetMonitorOnPortabilitySize _getportabilitysize;
        public GetAllCategoriesContractsLib.IGetAllCategories _getallcategories;
        public GetMonitorOnSizeContractsLib.IGetMonitorOnSize _getmonitoronsize;
        public GetMonitorOnPortabilityContractsLib.IGetMonitorOnPortability _getmonitoronportability;
        public MonitorController()
        {
            _con.RegisterType<IGetSeriesContractsLib.IGetSeries, GetSeriesLib.GetSeriesType>();
            _con.RegisterType<GetModelContractsLib.IGetModel, GetModelLib.GetModel>();
            _con.RegisterType<GetMonitorOnPortabilitySizeContractsLib.IGetMonitorOnPortabilitySize, GetMonitorOnPortabilitySizeLib.GetMonitorOnPortabilitySize>();
            _con.RegisterType<GetAllCategoriesContractsLib.IGetAllCategories, GetAllCategoriesLib.GetAllCategories>();
            _con.RegisterType<GetMonitorOnSizeContractsLib.IGetMonitorOnSize, GetMonitorOnSizeLib.GetMonitorOnSize>();
            _con.RegisterType<GetMonitorOnPortabilityContractsLib.IGetMonitorOnPortability,GetMonitorOnPortabilityLib.GetMonitorOnPortability>();
        }
        //-----------------------------------------------DONE--------------------------------------------------

        [Route("api/Monitor/GetSeries/{name}")]
        [HttpGet]
        public HttpResponseMessage GetSeries(string name = "all" )

        {
            _getseries = _con.Resolve<IGetSeriesContractsLib.IGetSeries>();
            try
            {
                    return Request.CreateResponse(HttpStatusCode.OK, _getseries.GetSeriesType(name));   
            }



            catch (Exception ex)
            { return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex); }
        }
         
    
            
            //------------------------------------------DONE---------------------------------------------------------
            [Route("api/Monitor/GetPortableMonitor/{portability}")]
            [HttpGet]
            public HttpResponseMessage GetPortableMonitor(string portability = "all")
            {
            _getmonitoronportability = _con.Resolve<GetMonitorOnPortabilityContractsLib.IGetMonitorOnPortability>();
            try
            {
                using (ChatBotDBEntities2 entities = new ChatBotDBEntities2())
                {
                    return Request.CreateResponse(HttpStatusCode.OK,_getmonitoronportability.GetMonitorOnPortability(portability));
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }


        }

        //------------------------------------------DONE--------------------------------------------------------------
            [Route("api/Monitor/GetMonitorSize/{size}")]
            [HttpGet]
            public HttpResponseMessage GetMonitorSize(string size = "All")
            {
            _getmonitoronsize = _con.Resolve<GetMonitorOnSizeContractsLib.IGetMonitorOnSize>();
            try
                {
                    using (ChatBotDBEntities2 entities = new ChatBotDBEntities2())
                    {
                        return Request.CreateResponse(HttpStatusCode.OK, _getmonitoronsize.GetMonitorOnSize(size));
                    }
                }
                catch (Exception ex)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
                }
            }
        //------------------------------------------------DONE------------------------------------------------------


        [Route("api/Monitor/GetAllCategories")]
        [HttpGet]
        //Get all distinct categories
        public HttpResponseMessage GetAllCategories()

        {
            _getallcategories = _con.Resolve<GetAllCategoriesContractsLib.IGetAllCategories>();
            try
            {
                
                    return Request.CreateResponse(HttpStatusCode.OK, _getallcategories.GetAllCategories());
                
            }

            catch (Exception ex)
            { return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex); }
        }



        //--------------------------------------------------------DONE-----------------------------------------------


        [Route("api/Monitor/{spec1}/{spec2}")]
        [HttpGet]
        public HttpResponseMessage GetMonitorOnPortablitySize(string spec1, string spec2)
        {

            _getportabilitysize = _con.Resolve<GetMonitorOnPortabilitySizeContractsLib.IGetMonitorOnPortabilitySize>();

            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _getportabilitysize.GetPortabilitySize(spec1,spec2));
            }

            catch (Exception ex)
            { return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex); }
        }



        //-------------------------------------------------------DONE-----------------------------------------------

        [Route("api/Monitor/GetModel/{model}")]
            [HttpGet]
            public HttpResponseMessage GetModel(string model = "All")
            {
            _getmodel = _con.Resolve<GetModelContractsLib.IGetModel>();
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _getmodel.GetModel(model));
            }



            catch (Exception ex)
            { return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex); }
        }

        }
    }
