using HomeWorkADONET.Interface;
using HomeWorkADONET.Utils;
using Microsoft.Data.SqlClient;
using System.Data;

namespace HomeWorkADONET.Models
{
    public class Status : IReader<Status>
    {
        public int Film { get; set; }
        public int Cinema { get; set; }
        public int Currency { get; set; }
        public string Passport { get; set; }



        public override string ToString()
        {
            return $"FilmNumner{Film} , CinemaNumber{Cinema} , CurrencyNumber{Currency} , PassportNumber{Passport}";
        }
        public IEnumerable<Status> Get(string request)
        {
            List<Status> statuses = new();
            CreateLineConnection createLineConnection = new();
            using (SqlConnection connect = new SqlConnection(createLineConnection._connectionString))
            {
                connect.Open();
                using (SqlCommand command = connect.CreateCommand())
                {
                    command.CommandType = CommandType.Text;
                    command.CommandText = request;
                    var reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Status status = new Status
                            {
                                Film = reader.GetInt32(nameof(Statuses.FILMS)),
                                Cinema = reader.GetInt32(nameof(Statuses.CINEMA)),
                                Currency = reader.GetInt32(nameof(Statuses.CURRENCY)),
                                Passport = reader.GetString(nameof(Statuses.PASSPORT))
                            };

                            statuses.Add(status);
                        }
                    }



                    return statuses;
                }


            }
        }
    }

    public enum Statuses
    {
        FILMS =1,
        CINEMA,
        CURRENCY,
        PASSPORT
    }
}
