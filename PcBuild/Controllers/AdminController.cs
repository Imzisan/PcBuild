using BLL.DTOs;
using BLL.Services;
using PcBuild.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Xml.Linq;

namespace PcBuild.Controllers
{
    public class AdminController : ApiController
    {
        [HttpGet]
        [Route("api/admin")]
        public HttpResponseMessage Admins()
        {
            try
            {
                var data = AdminService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/admin/{id}")]
        public HttpResponseMessage Admins(string id)
        {
            try
            {
                var data = AdminService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpPost]
        [Route("api/admin/create")]

        public HttpResponseMessage Create(AdminDTO Sname)
        {
            try
            {
                var data = AdminService.Create(Sname);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message, Data = Sname });
            }
        }
        [HttpPost]
        [Route("api/admin/delete/{id}")]
        public HttpResponseMessage Delete(string Id)
        {
            try
            {

                return Request.CreateResponse(HttpStatusCode.OK, AdminService.Delete(Id));
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }
        //[HttpPost]
        //[Route("api/admin/update")]
        //public HttpResponseMessage Update(AdminDTO obj)
        //{
        //    try
        //    {
        //        var data = AdminService.Update(obj);
        //        return Request.CreateResponse(HttpStatusCode.OK, data);

        //    }
        //    catch (Exception ex)
        //    {

        //        return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message, Data = obj });
        //    }
        //}



    }
}

