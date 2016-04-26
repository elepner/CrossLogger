using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http;
using CrossLogger.Code;
using Microsoft.Owin;
using Ninject.Web.Common.OwinHost;
using Ninject.Web.WebApi.OwinHost;
using Owin;

[assembly: OwinStartup(typeof(CrossLogger.Startup))]
namespace CrossLogger
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var httpConfig = new HttpConfiguration();
            httpConfig.MapHttpAttributeRoutes();
            httpConfig.Formatters.JsonFormatter.SerializerSettings.ContractResolver =
                new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver();
            httpConfig.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
            app.UseNinjectMiddleware(() => NinjectConfig.CreateKernel.Value);
            app.UseNinjectWebApi(httpConfig);
        }
    }
}