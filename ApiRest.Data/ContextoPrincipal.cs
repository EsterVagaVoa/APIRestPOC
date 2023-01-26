using ApiRest.Domain;
using Microsoft.EntityFrameworkCore;

namespace ApiRest.Data
{
    public class ContextoPrincipal : DbContext
    {
        protected ContextoPrincipal(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Cliente>
    }
}