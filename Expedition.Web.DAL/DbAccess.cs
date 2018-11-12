using System;
using System.Threading.Tasks;
using Expedition.Web.DAL.Abstractions.DbContext;
using Expedition.Web.DAL.DbContext;

namespace Expedition.Web.DAL
{
    public class DbAccess : IDbAccess
    {
        private readonly ExpeditionDbContex _dbContex;

        public DbAccess(ExpeditionDbContex dbContex)
        {
            _dbContex = dbContex;
        }

        public async Task ProcessRequest(Func<Microsoft.EntityFrameworkCore.DbContext, Task> action)
        {
            try
            {
                await action(_dbContex);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}