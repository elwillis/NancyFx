using log4net;
using Nancy;

namespace Tezra.Service.Controllers
{
    public class DefaultModule : NancyModule
    {
        private ILog _logger;

        public DefaultModule(ILog logger):base()
        {
            _logger = logger;

            Get["/"] = _ =>
            {
                _logger.Info("Nancy Module Start");
                return Response.AsJson("Hello World...");
            };
        }
    }
}