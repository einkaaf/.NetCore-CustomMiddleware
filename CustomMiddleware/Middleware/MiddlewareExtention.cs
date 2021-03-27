using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomMiddleware.Middleware
{
    public static class MiddlewareExtention
    {
        public static IApplicationBuilder UseCustomLogger(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CustomLogger>();
        } 
    }
}
