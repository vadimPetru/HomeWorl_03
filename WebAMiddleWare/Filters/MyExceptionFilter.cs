using Microsoft.AspNetCore.Mvc.Filters;

namespace WebAMiddleWare.Filters
{
    public class MyExceptionFilter : Attribute, IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            using (StreamWriter stream = new("FilterWork.txt", true))
            {
                stream.WriteLine("Exception - OnException");
            }; ;
        }
    }
}
