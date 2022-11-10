using HomeWorkADONET.Interface;
using HomeWorkADONET.Models;
using HomeWorkADONET.Utils;

namespace HomeWorkADONET.Service
{
    public class TicketSystemService 
    {
        private CreateLineConnection _dbWorker;
       

        public TicketSystemService(CreateLineConnection dbWorker)
        {
            _dbWorker = dbWorker;
        }

        public IEnumerable<IReader<Cinema>> GetCinema()
        {
            return _dbWorker.GetInformationCinema();
        }

        public IEnumerable<IReader<Clients>> GetClients()
        {
            return _dbWorker.GetInformationClients();
        }

        public IEnumerable<IReader<Films>> GetFilms()
        {
            return _dbWorker.GetInformationFilms();
        }

        public IEnumerable<IReader<Status>> GetStatus()
        {
            return _dbWorker.GetInformationStatus();
        }

        public IEnumerable<IReader<Currency>> GetCurrency()
        {
            return _dbWorker.GetInformationCurrency();
        }
    }
}
