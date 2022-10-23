using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebAMiddleWare.Filters
{
    public class MyAuthorizationFilter : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            using (StreamWriter stream = new("FilterWork.txt", true))
            {
                stream.WriteLine("Authorization -OnAuthorization");
            }; ;
        }
    }
}
