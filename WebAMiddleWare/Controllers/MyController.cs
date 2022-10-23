using Microsoft.AspNetCore.Mvc;
using WebAMiddleWare.Models;

namespace WebAMiddleWare.Controllers
{
    public class MyController : Controller
    {
       
        public IActionResult GetWorker()
        {
            Worker worker = new()
            {
                Name = "Вадим",
                Adress = "Минск",
                Age = "28",
                DateOfBirth = "13.09.1994"
            };

            return View(worker);
        }
    }
}
