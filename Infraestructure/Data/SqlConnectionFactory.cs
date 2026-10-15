using Microsoft.Data.SqlClient;
using System.Data;

namespace InventarySystem.Infraestructure.Data
{
    public class SqlConnectionFactory: IDbConnectionFactory
    {
        private readonly string _connectionString;
        public SqlConnectionFactory(string conectionString) => _connectionString = conectionString;

        public async Task<IDbConnection> CreateOpenConnectionAsync()
        {
            var conn = new SqlConnection(_connectionString);
            await conn.OpenAsync();
            return conn;
        }
    }
}