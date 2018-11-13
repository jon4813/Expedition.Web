using System.Threading.Tasks;

namespace Expedition.Web.DAL.Abstractions.Repositories.Base
{
    public interface IRepository<TEntity>: IReadOnlyRepository<TEntity> where TEntity : Entity, new()
    {
        Task Create(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(TEntity entity);
    }
}