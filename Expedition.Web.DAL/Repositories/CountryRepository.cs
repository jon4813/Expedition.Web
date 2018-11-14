using Expedition.Web.DAL.Abstractions.DbContext;
using Expedition.Web.DAL.Abstractions.Entities;
using Expedition.Web.DAL.Abstractions.Repositories;
using Expedition.Web.DAL.Repositories.Base;

namespace Expedition.Web.DAL.Repositories
{
    public class CountryRepository : Repository<Country>, ICountryRepository
    {
        public CountryRepository(IDbAccess dbAccess) : base(dbAccess)
        {
        }
    }
}