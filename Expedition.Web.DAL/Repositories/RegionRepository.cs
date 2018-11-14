using Expedition.Web.DAL.Abstractions.DbContext;
using Expedition.Web.DAL.Abstractions.Entities;
using Expedition.Web.DAL.Abstractions.Repositories;
using Expedition.Web.DAL.Repositories.Base;

namespace Expedition.Web.DAL.Repositories
{
    public class RegionRepository : Repository<Region>, IRegionRepository
    {
        public RegionRepository(IDbAccess dbAccess) : base(dbAccess)
        {
        }
    }
}