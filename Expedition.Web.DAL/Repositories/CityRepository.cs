using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Expedition.Web.DAL.Abstractions;
using Expedition.Web.DAL.Abstractions.DbContext;
using Expedition.Web.DAL.Abstractions.Repositories;
using Expedition.Web.DAL.DbContext;

namespace Expedition.Web.DAL.Repositories
{
    public class CityRepository : Repository<City>, ICityRepository
    {
        public CityRepository(IDbAccess dbAccess) : base(dbAccess)
        {
        }

        public async Task<IEnumerable<City>> GetAll()
        {
            IEnumerable<City> result = Enumerable.Empty<City>();
            await DbAccess.ProcessRequest(context =>
            {
                result = ((ExpeditionDbContex) context).Cities;
                return Task.CompletedTask;
            });

            return result;
        }
    }
}