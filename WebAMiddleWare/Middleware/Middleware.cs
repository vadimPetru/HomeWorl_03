using Microsoft.AspNetCore.Http.Extensions;

namespace WebAMiddleWare.Middleware
{
    public class Middleware
    {
        private readonly RequestDelegate _next;
        public Middleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext context)
        {
       
            using (StreamWriter Dimer = new("answer.txt", true))
            {
               Dimer.WriteLine(context.Request.GetDisplayUrl());
            }
           
            
            return _next(context);
        }
    }
}
