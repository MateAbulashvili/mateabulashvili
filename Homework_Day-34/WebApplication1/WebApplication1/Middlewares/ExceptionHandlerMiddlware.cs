using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DependencyInjectionDemo.Middlewares
{
    public class ExceptionHandlerMiddlware
    {
        private readonly RequestDelegate _next;

        public ExceptionHandlerMiddlware(RequestDelegate next)
        {
            _next = next;

        }

        public async Task Invoke(HttpContext context)
        {
            try
            { 
                await _next.Invoke(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            var error = new ApiError(context, ex);

            if(error.Status == (int)HttpStatusCode.InternalServerError)
            {
                context.Response.Clear();
                context.Response.StatusCode = 500;
                context.Response.ContentType = "text/html";

                await context.Response.WriteAsync("<html><body>\r\n");
                await context.Response.WriteAsync($"<h1>Internal Error</h1><br>\r\n");
                await context.Response.WriteAsync($"<h3>Sorry for Inconvinience</h3><br><br>\r\n");
                await context.Response.WriteAsync($"<img src='https://www.joomdev.com/images/easyblog_articles/113/500-errors--.jpg'/>\r\n");
                await context.Response.WriteAsync("</body></html>\r\n");

            }
            else
            {
                var result = JsonConvert.SerializeObject(error);
                context.Response.Clear();
                context.Response.ContentType = "application/json";
                context.Response.StatusCode = error.Status.Value;
                await context.Response.WriteAsync(result);
            }
            


           
        }
    }
}
