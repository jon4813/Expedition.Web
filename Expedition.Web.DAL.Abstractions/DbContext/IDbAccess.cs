using System;
using System.Threading.Tasks;

namespace Expedition.Web.DAL.Abstractions.DbContext
{
    public interface IDbAccess
    {
        Task ProcessRequest(Func<Microsoft.EntityFrameworkCore.DbContext, Task> action);
    }
}