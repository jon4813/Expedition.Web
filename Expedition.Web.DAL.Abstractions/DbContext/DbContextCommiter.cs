using System.Threading.Tasks;

namespace Expedition.Web.DAL.Abstractions.DbContext
{
    public interface IDbContextCommiter
    {
        Task SaveAsync(bool throwIfNothing = false);
    }
}