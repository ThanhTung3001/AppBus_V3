using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Data.Connections;
using Microsoft.Extensions.Configuration;

namespace Data.Repos
{
    public class RouteRepository :AppDbConnection, IRouteRepository
    {
        public RouteRepository(IConfiguration config) : base(config)
        {
        }

        public async Task<List<object>> GetStation()
        {
            using (var con = GetConnection())
            {
                var result = await con.QueryAsync("Select * from Hb_Diem");
                return result.ToList();
            }
        }
    }
}