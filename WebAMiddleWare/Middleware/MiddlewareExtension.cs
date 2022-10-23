namespace WebAMiddleWare.Middleware
{
    public static class MiddlewareExtension
    {

        public  static void UseMyMiddleware(this IApplicationBuilder builder)
        {
            builder.UseMiddleware<Middleware>();
        }
    }
}
