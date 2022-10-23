using Microsoft.AspNetCore.Mvc.Filters;
using System.Buffers;
using System.Formats.Asn1;

namespace WebAMiddleWare.Filters
{
    public class MyActionFilter : Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            using (StreamWriter stream = new("FilterWork.txt", true))
            {
                stream.WriteLine("Action - OnActionExecuted");
            };
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {

            using (StreamWriter stream = new("FilterWork.txt", true))
            {
                stream.WriteLine("Action - OnActionExecuting");
            };
        }
    }
}
