using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Cors;
using System.Web.Http.Cors;

namespace CORS_SandBox_API.Filter
{
    public class CorsHandleAttribute : Attribute, ICorsPolicyProvider
    {
        private CorsPolicy _Policy;
        public CorsHandleAttribute()
        {
            _Policy = new CorsPolicy()
            {
                Methods = { "POST" },
                //AllowAnyMethod = true,
                AllowAnyHeader = true
            };
            _Policy.Origins.Add("https://localhost:44354");

        }
        public Task<CorsPolicy> GetCorsPolicyAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_Policy);
        }
    }
}