using System.Collections.Generic;
using System.Threading.Tasks;
namespace Data.Repos
{
    public interface IRouteRepository{
        
        public Task<List<object>>GetStation();
    }
}