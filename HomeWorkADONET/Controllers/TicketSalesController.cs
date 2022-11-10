using HomeWorkADONET.Service;
using Microsoft.AspNetCore.Mvc;
using HomeWorkADONET.Utils;

namespace HomeWorkADONET.Controllers
{
    public class TicketSalesController : Controller
    {

        private TicketSystemService _ticketSystemService;

        public TicketSalesController()
        {
            _ticketSystemService = new TicketSystemService(new CreateLineConnection());
        }
       

        public IActionResult MenuShows(string button)
        {
            
            if (button == "Clients")
            {
                var clients = _ticketSystemService.GetClients();
                return View("Clients",clients);
            }
            if(button == "Cinema")
            {
                var Cinemas = _ticketSystemService.GetCinema();
                return View("Cinema",Cinemas);
            }
            if (button == "Currency")
            {
                var Currencies = _ticketSystemService.GetCurrency();
                return View("Currency", Currencies);
            }
            if (button == "Films")
            {
                var Films = _ticketSystemService.GetFilms();
                return View("Films",Films);
            }
            if (button == "Status")
            {
                var Statuses = _ticketSystemService.GetStatus();
                return View("Status",Statuses);
            }
            return View();
        }  
           
        

        
    }
}
