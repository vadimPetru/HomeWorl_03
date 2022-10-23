using Microsoft.AspNetCore.Mvc.Filters;

namespace WebAMiddleWare.Filters
{
    public class MyResultFilter : Attribute, IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext context)
        {
            using (StreamWriter stream = new("FilterWork.txt", true))
            {
                stream.WriteLine("Result - OnResultExecuted");
            };
        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            using (StreamWriter stream = new("FilterWork.txt", true))
            {
                stream.WriteLine("Result - OnResultExecuting");
            };
        }
    }
}
