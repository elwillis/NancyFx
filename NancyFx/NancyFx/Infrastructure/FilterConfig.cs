using System.Web.Http;

namespace Tezra.Service.Infrastructure
{
    public class FilterConfig
    {
        public static void Configure(HttpConfiguration config)
        {
            config.Filters.Add(new AuthorizeAttribute());
        }
    }
}