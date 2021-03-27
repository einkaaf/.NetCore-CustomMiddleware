using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace CustomMiddleware.Middleware
{
    public class CustomLogger
    {
        private readonly RequestDelegate _request;

        public CustomLogger(RequestDelegate request)
        {
            _request = request;
        }
        public Task Invoke(HttpContext context)
        {
            Log(context);

            return _request(context);
        }

        public void Log(HttpContext context)
        {
            System.Console.WriteLine("This is Query string : "+context.Request.QueryString.Value);
            System.Console.WriteLine("This is Method : " + context.Request.Method);
        }
    }
}
