using BLL.Services;
using PcBuild.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Services.Description;

namespace PcBuild.Controllers
{
    public class ModeratorController : ApiController
    {
        [HttpGet]
        [Route("api/moderator")]
        public  HttpResponseMessage Moderators()
        {
            try
            {
                var data = ModeratorService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/moderator/{id}")]
        public HttpResponseMessage Moderators( string id)
        {
            try
            {
                var data = ModeratorService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/moderator/{id}/salesreport")]
        public HttpResponseMessage ModeratorSalesReport (string id)
        {
            try
            {
                var data = ModeratorService.GetwithSalesReport(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
    }
}
