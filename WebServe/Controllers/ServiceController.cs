using PublicClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebServe.Utility;

namespace WebServe.Controllers
{
    [EnableCors("*", "*", "*")]
    [RoutePrefix("service")]
    public class ServiceController : ApiController
    {
        [RequestAuthorize]
        [HttpPost]
        [Route("send")]
        public object SendAllService([FromBody]object value)
        {
            GearClass request = new GearClass(value + "");

            //返回调用方法获取的值
            return request.Send();
        }
    }
}
