

namespace HomeWorkADONET.Utils
{
    using HomeWorkADONET.Interface;
    using HomeWorkADONET.Models;
    using Microsoft.Data.SqlClient;
   

    public class CreateLineConnection
    {
        public string _connectionString;
        public IReader<Cinema> readerCinema = new Cinema();
        public IReader<Clients> readerClients = new Clients();
        public IReader<Currency> readerCurrency = new Currency();
        public IReader<Films> readerFilms = new Films();
        public IReader<Status> readerStatus = new Status();
        public CreateLineConnection()
        {
            SqlConnectionStringBuilder stringBuilder = new();
            stringBuilder.DataSource = "localhost\\SQLEXPRESS";
            stringBuilder.InitialCatalog = "TICKETSYSTEMSALES";
            stringBuilder.IntegratedSecurity = true;
            stringBuilder.TrustServerCertificate = true;
            _connectionString = stringBuilder.ConnectionString;
        }
        public IEnumerable<IReader<Cinema>> GetInformationCinema()
        {
            return readerCinema.Get("SELECT * FROM CINEMA");
        }

        public IEnumerable<IReader<Clients>> GetInformationClients()
        {
            return readerClients.Get("SELECT * FROM CLIENTS");
        }

        public IEnumerable<IReader<Films>> GetInformationFilms()
        {
            return readerFilms.Get("SELECT * FROM FILMS");
        }

        public IEnumerable<IReader<Currency>> GetInformationCurrency()
        {
            return readerCurrency.Get("SELECT * FROM CURRENCY");
        }

        public IEnumerable<IReader<Status>> GetInformationStatus()
        {
            return readerStatus.Get("SELECT * FROM STATUS");
        }

    }

}
