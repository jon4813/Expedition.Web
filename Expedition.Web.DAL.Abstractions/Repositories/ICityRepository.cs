using System.Collections.Generic;
using System.Threading.Tasks;
using Expedition.Web.DAL.Abstractions.Repositories.Base;

namespace Expedition.Web.DAL.Abstractions.Repositories
{
    public interface ICityRepository : IRepository<City>
    {
        Task<IEnumerable<City>> GetAll();
    }
}