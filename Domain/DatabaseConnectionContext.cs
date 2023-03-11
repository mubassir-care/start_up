using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Domain
{
    public class DatabaseConnectionContext
    {
        private readonly IConfiguration _configuration;

        public DatabaseConnectionContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IDbConnection CreateMartConnection() => new SqlConnection(_configuration.GetConnectionString("DBConStrLinkage"));
    }
}