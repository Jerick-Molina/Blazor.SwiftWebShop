using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataBaseAccess.Data.Services
{
    public interface ISqlDataAccess
    {
        string ConnectionString { get; set; }
        Task<List<T>> ConnectSql<T, U>(string sql, U parameters);
    }
}