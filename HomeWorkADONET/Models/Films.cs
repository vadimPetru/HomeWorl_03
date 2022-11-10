using HomeWorkADONET.Interface;
using HomeWorkADONET.Utils;
using Microsoft.Data.SqlClient;
using System.Data;

namespace HomeWorkADONET.Models
{
    public class Films : IReader<Films>
    {
        public int FilmId { get; set; }
        public string? FilmName { get; set; }
        public DateTime? FilmDate { get; set; }
        public decimal? Price { get; set; }


        public override string ToString()
        {
            return $"{FilmId}: {FilmName}, Date{FilmDate}, Price{Price}";
        }

        public IEnumerable<Films> Get(string request)
        {
            List<Films> films = new();
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
                            Films film = new Films
                            {
                                FilmId = reader.GetInt32(nameof(Film.FILM_ID)),
                                FilmName = reader.GetString(nameof(Film.FILM_NAME)),
                                FilmDate = reader.GetDateTime(nameof(Film.FILM_DAY)),
                                Price = reader.GetDecimal(nameof(Film.PRICE))
                            };

                            films.Add(film);

                        }
                    }
                    return films;
                }


            }
        }
    }

    public enum Film
    {
        FILM_ID =1,
        FILM_NAME,
        FILM_DAY,
        PRICE
    }
}
