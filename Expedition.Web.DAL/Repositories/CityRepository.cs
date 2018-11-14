using Expedition.Web.DAL.Abstractions;
using Expedition.Web.DAL.Abstractions.DbContext;
using Expedition.Web.DAL.Abstractions.Entities;
using Expedition.Web.DAL.Abstractions.Repositories;
using Expedition.Web.DAL.Repositories.Base;

namespace Expedition.Web.DAL.Repositories
{
    public class CityRepository : Repository<City>, ICityRepository
    {
        public CityRepository(IDbAccess dbAccess) : base(dbAccess)
        {
        }
    }
}