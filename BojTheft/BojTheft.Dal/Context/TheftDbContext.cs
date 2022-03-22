using BojTheft.Dal.Pocos;
using Microsoft.EntityFrameworkCore;

namespace BojTheft.Dal.Context
{
    public class TheftDbContext : DbContext
    {
        public TheftDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Theft> Thefts { get; set; }
    }
}
