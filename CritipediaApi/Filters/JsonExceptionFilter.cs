using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Net;

namespace CritipediaApi.Filters
{
    public class JsonExceptionFilter : IExceptionFilter
    {
        ILogger _log;
        public JsonExceptionFilter(ILogger log)
        {
            _log = log;
        }
        public void OnException(ExceptionContext context)
        {
            // Do logging here
            _log.LogError("Exception ocurred!", context); 
        }

    }
}
