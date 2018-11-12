using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Expedition.Web.DAL.Abstractions.Repositories.Base
{
    public interface IReadOnlyRepository<TEntity> where TEntity : class, new()
    {
        //Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> GetById(Guid id);
    }
}