using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Data.Connections
{
    public class AppDbConnection
    {
        private readonly IConfiguration _config;

        public SqlConnection _conn { get; set; }

        public AppDbConnection(IConfiguration config)
        {
            _config = config;
        }
        public SqlConnection GetConnection(){
            try
            {
                var connection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
                return connection;
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
    }
}