using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Expedition.Web.DAL.Abstractions.DbContext;
using Expedition.Web.DAL.Abstractions.Repositories.Base;

namespace Expedition.Web.DAL.Repositories
{
    public class ReadOnlyRepository<TEntity> : IReadOnlyRepository<TEntity> where TEntity : class, new()
    {
        protected readonly IDbAccess DbAccess;

        public ReadOnlyRepository(IDbAccess dbAccess)
        {
            DbAccess = dbAccess;
        }

        //public async Task<IEnumerable<TEntity>> GetAll()
        //{
        //    IEnumerable<TEntity> result = Enumerable.Empty<TEntity>();
        //    await DbAccess.ProcessRequest(context =>
        //    {
        //        result = context.Query<TEntity>();
        //        return Task.CompletedTask;
        //    });

        //    return result;
        //}

        public async Task<TEntity> GetById(Guid id)
        {
            TEntity entity = default(TEntity);
            await DbAccess.ProcessRequest(async context =>
            {
                entity = await context.FindAsync<TEntity>(id);
            });

            return entity;
        }
    }
}