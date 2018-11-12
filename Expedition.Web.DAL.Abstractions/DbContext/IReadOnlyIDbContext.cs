using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Expedition.Web.DAL.Abstractions.DbContext
{
    public interface IReadOnlyIDbContext
    {
        Task<IEnumerable<TEntity>> GetAllAsync<TEntity>() where TEntity : class, new();
        Task<TEntity> GetByIdAsync<TEntity>(Guid id) where TEntity : class, new();

        Task<IEnumerable<TEntity>> QueryAsync<TEntity>(Expression<TEntity> query) where TEntity : class, new();
    }
}