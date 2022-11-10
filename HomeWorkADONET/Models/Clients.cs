using HomeWorkADONET.Interface;
using HomeWorkADONET.Utils;
using Microsoft.Data.SqlClient;
using System.Data;


namespace HomeWorkADONET.Models
{
    public class Clients : IReader<Clients>

    {
        public string? Passport { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }

        public string? Address { get; set; }
        public DateTime DateOfBirth { get; set; }


      

        public override string ToString()
        {
            return $"Пасспорт{Passport}, Имя:{Name} , Фамилия{Surname} ,Адрес{Address} , День рождения{DateOfBirth}";
        }

        public IEnumerable<Clients> Get(string request)
        {
            List<Clients> clients = new();
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
                            Clients client = new Clients
                            {
                                Passport = reader.GetString(nameof(Client.PASSPORT_ID)),
                                Name = reader.GetString(nameof(Client.NAME)),
                                Surname = reader.GetString(nameof(Client.SURNAME)),
                                Address = reader.GetString(nameof(Client.ADDRESS)),
                                DateOfBirth = reader.GetDateTime(nameof(Client.DATE_OF_BIRTH))
                            };
                            clients.Add(client);
                        }
                    }



                   
                }
                return clients;

            }
        }

      
    }

    public enum Client
    {
        PASSPORT_ID,
        NAME,
        SURNAME,
        ADDRESS,
        DATE_OF_BIRTH
    }

}
