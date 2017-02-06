using Owin;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Tezra.Service
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //WebApi Http Configuration.
            HttpConfiguration httpConfig = new HttpConfiguration();
            ConfigureWebApi(httpConfig);

            app.Map("/nancy", branch => branch.UseNancy())
               .Map("/webapi", branch => branch.UseWebApi(httpConfig));
        }

        private void ConfigureWebApi(HttpConfiguration httpConfig)
        {
            var cors = new EnableCorsAttribute("*", "*", "*");
            httpConfig.EnableCors(cors);
            httpConfig.MapHttpAttributeRoutes();
            //FilterConfig.Configure(httpConfig);
        }
    }
}