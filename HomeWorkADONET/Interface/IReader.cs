using HomeWorkADONET.Utils;
using Microsoft.Data.SqlClient;
using System.Data;
namespace HomeWorkADONET.Interface
{
    public interface IReader<T>
    {
        public IEnumerable<T> Get(string request);

       
    }
}
