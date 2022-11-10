using HomeWorkADONET.Interface;
using HomeWorkADONET.Utils;
using Microsoft.Data.SqlClient;
using System.Data;

namespace HomeWorkADONET.Models
{
    public class Currency : IReader<Currency>
    {
        public int CurrencyId { get; set; }
        public string? CurrencyName { get; set; }


        public override string ToString()
        {
            return $"{CurrencyId} - Название:{CurrencyName}";
        }
        public IEnumerable<Currency> Get(string request)
        {
            List<Currency> currencies = new();
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
                            Currency currency = new Currency
                            {
                                CurrencyId = reader.GetInt32(nameof(Currencies.CURRENCY_ID)),
                                CurrencyName = reader.GetString(nameof(Currencies.CURRENCY_NAME))
                            };

                            currencies.Add(currency);

                        }
                    }



                    return currencies;
                }


            }
        }
    }
  
    public enum Currencies
    {
        CURRENCY_ID = 1,
        CURRENCY_NAME= 2
    }
}
