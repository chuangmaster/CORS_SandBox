using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace CORS_SandBox_API.Filter
{
    public class AllowCORSAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            actionContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");
            actionContext.Response.Headers.Add("Access-Control-Allow-Headers", "Content-Type");
            actionContext.Response.Headers.Add("Access-Control-Allow-Methods", "POST");
            base.OnActionExecuting(actionContext);
        }
    }
}