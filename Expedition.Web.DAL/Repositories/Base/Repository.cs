using System.Threading.Tasks;
using Expedition.Web.DAL.Abstractions.DbContext;
using Expedition.Web.DAL.Abstractions.Repositories.Base;

namespace Expedition.Web.DAL.Repositories
{
    public class Repository<TEntity> : ReadOnlyRepository<TEntity>, IRepository<TEntity> where TEntity : class, new()
    {
        public Repository(IDbAccess dbAccess) : base(dbAccess)
        {
        }

        public async Task Create(TEntity entity)
        {
            await DbAccess.ProcessRequest(async context =>  await context.AddAsync(entity));
        }

        public async Task Update(TEntity entity)
        {
            await DbAccess.ProcessRequest(context =>
            {
                context.Update(entity);
                return Task.CompletedTask;
            });
        }

        public async Task Delete(TEntity entity)
        {
            await DbAccess.ProcessRequest(context =>
            {
                context.Entry(entity).Property<bool>("IsArchived").CurrentValue = true;
                return Task.CompletedTask;
            });
        }
    }
}