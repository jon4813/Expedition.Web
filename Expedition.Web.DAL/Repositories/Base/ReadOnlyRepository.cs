using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Expedition.Web.DAL.Abstractions;
using Expedition.Web.DAL.Abstractions.DbContext;
using Expedition.Web.DAL.Abstractions.Repositories.Base;

namespace Expedition.Web.DAL.Repositories.Base
{
    public class ReadOnlyRepository<TEntity> : IReadOnlyRepository<TEntity> where TEntity : Entity, new()
    {
        protected readonly IDbAccess DbAccess;

        public ReadOnlyRepository(IDbAccess dbAccess)
        {
            DbAccess = dbAccess;
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            var result = Enumerable.Empty<TEntity>();
            await DbAccess.ProcessRequest(context =>
            {
                result = context.Set<TEntity>().ToList();
                return Task.CompletedTask;
            });

            return result;
        }

        public async Task<TEntity> GetById(Guid id)
        {
            var entity = default(TEntity);
            await DbAccess.ProcessRequest(async context => { entity = await context.FindAsync<TEntity>(id); });

            return entity;
        }
    }
}