﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using CORS_SandBox_API.Filter;
using CORS_SandBox_API.Models;
namespace CORS_SandBox_API.Controllers
{
    public class ValuesController : ApiController
    {

        [HttpPost]
        [Route("~/api/v1/simpleRequest")]
        public HttpResponseMessage SimpleRequest([FromBody]string value)
        {
            var resp = Request.CreateResponse(HttpStatusCode.OK, "OK");

            resp.Content.Headers.Add("Access-Control-Allow-Origin", "*");
            return resp;
        }

        [HttpPost]
        [Route("~/api/v1/normalRequest/error")]
        public HttpResponseMessage NormalRequest_error(NormalRequestParameter parameter)
        {
            var resp = Request.CreateResponse(HttpStatusCode.OK, "OK");

            resp.Content.Headers.Add("Access-Control-Allow-Origin", "*");
            return resp;
        }

        [HttpPost]

        //[CorsHandle]
        [EnableCors("https://localhost:44354", "*", "POST")]
        [Route("~/api/v1/normalRequest/success")]
        public HttpResponseMessage NormalRequest_success(NormalRequestParameter parameter)
        {
            var resp = Request.CreateResponse(HttpStatusCode.OK,"OK");
            return resp;
        }

        [HttpOptions]
        [Route("~/api/v1/normalRequest/success")]
        public HttpResponseMessage NormalRequest_option(NormalRequestParameter parameter)
        {
            var resp = Request.CreateResponse(HttpStatusCode.OK, "OK");

            resp.Content.Headers.Add("Access-Control-Allow-Methods", "POST");
            resp.Content.Headers.Add("Access-Control-Allow-Headers", "Content-Type");
            resp.Content.Headers.Add("Access-Control-Allow-Origin", "*");

            //resp.Content.Headers.Add("Access-Control-Allow-Headers", "Content-Type");



            return resp;
        }

    }
}