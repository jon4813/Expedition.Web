using System;
using System.Threading.Tasks;
using Expedition.Web.DAL.Abstractions.DbContext;

namespace Expedition.Web.DAL.DbContext
{
    public class DbContextCommiter : IDbContextCommiter
    {
        private readonly ExpeditionDbContex _dbContex;

        public DbContextCommiter(ExpeditionDbContex dbContex)
        {
            _dbContex = dbContex;
        }

        public async Task SaveAsync(bool throwIfNothing)
        {
            try
            {
                await _dbContex.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
                        
        }
    }
}