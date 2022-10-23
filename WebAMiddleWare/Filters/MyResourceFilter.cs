using Microsoft.AspNetCore.Mvc.Filters;

namespace WebAMiddleWare.Filters
{
    public class MyResourceFilter : Attribute, IResourceFilter
    {
        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            using (StreamWriter stream = new("FilterWork.txt", true))
            {
                stream.WriteLine("Resource - OnResourceExecuted");
            };
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            using (StreamWriter stream = new("FilterWork.txt", true))
            {
                stream.WriteLine("Resource - OnResourceExecuting");
            };
        }
    }
}
