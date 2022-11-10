using HomeWorkADONET.Interface;
using HomeWorkADONET.Utils;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Net;
using System.Reflection.PortableExecutable;

namespace HomeWorkADONET.Models
{
    public class Cinema : IReader<Cinema>
    {
        public int CinemaId { get; set; }
        public string? CinemaName { get; set; }

        public override string ToString()
        {
            return $"Ключ{CinemaId} , Имя{CinemaName}";
        }

        public IEnumerable<Cinema> Get(string request)
        {
            List<Cinema> cinemas = new();
            CreateLineConnection createLineConnection = new();
            using(SqlConnection connect = new SqlConnection(createLineConnection._connectionString))
            {
                connect.Open();
                using(SqlCommand command = connect.CreateCommand())
                {
                    command.CommandType = CommandType.Text;
                    command.CommandText = request;
                    var reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Cinema cinema = new Cinema
                            {
                                    CinemaId = reader.GetInt32(nameof(Cinemes.CINEMA_ID)),
                                    CinemaName = reader.GetString(nameof(Cinemes.CINEMA_NAME))
                            };
                           

                            cinemas.Add(cinema);
                            
                        }
                    }



                    return cinemas;
                }

              
            }


               

            
        }

        
    }

  

    public enum Cinemes
    {
        CINEMA_ID = 1,
        CINEMA_NAME = 2
    }

    
}
