using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using CrossLogger.Models;

namespace CrossLogger.Controllers
{
    [RoutePrefix("api/v1")]
    public class AdministrationController : ApiController
    {
        [Route("service_info")]
        public IHttpActionResult GetRecords()
        {
            return Ok(new ServiceInfo());
        }

    }
}