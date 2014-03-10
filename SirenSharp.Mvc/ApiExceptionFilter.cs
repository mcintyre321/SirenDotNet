using System.Threading.Tasks;

namespace SirenSharp.Mvc
{
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Web.Http.Filters;

    public class ApiExceptionFilter : IExceptionFilter
    {
        public ApiExceptionFilter()
        {
            AllowMultiple = false;
        }

        public bool AllowMultiple { get; private set; }

        public Task ExecuteExceptionFilterAsync(HttpActionExecutedContext actionExecutedContext, CancellationToken cancellationToken)
        {
            if (actionExecutedContext.Exception is ParameterInvalidException)
            {
                actionExecutedContext.Response = new HttpResponseMessage(HttpStatusCode.BadRequest) { Content = new ApiContent<Exception>(new Exception((int)ErrorCode.ParameterInvalid, actionExecutedContext.Exception.Message)) };
                return Task.Factory.StartNew(() => { }, cancellationToken);                
            }

            actionExecutedContext.Response = new HttpResponseMessage(HttpStatusCode.InternalServerError) { Content = new ApiContent<Exception>(new Exception(0, actionExecutedContext.Exception.Message)) };
            return Task.Factory.StartNew(() => { }, cancellationToken);
        }
    }
}
