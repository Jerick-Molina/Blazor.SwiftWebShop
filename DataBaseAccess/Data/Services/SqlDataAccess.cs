using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Linq;

namespace DataBaseAccess.Data.Services
{
    public class SqlDataAccess : ISqlDataAccess
    {
        public readonly IConfiguration _config;

        public string ConnectionString { get; set; } = "Default";

        public SqlDataAccess(IConfiguration configuration)
        {
            _config = configuration;
        }


        public async Task<List<T>> ConnectSql<T, U>(string sql, U parameters)
        {
            var connectionString = _config.GetConnectionString(ConnectionString);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                var data = await connection.QueryAsync<T>(sql, parameters);

                return data.ToList();
            }
        }

        
    }
}
