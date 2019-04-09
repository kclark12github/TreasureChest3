using Microsoft.EntityFrameworkCore;
using TC3Core.Domain.Classes.Stash;

namespace TC3Core.Data
{
    public class TC3DbContext : DbContext
    {
        public TC3DbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Decal> Decals { get; set; }
    }
}
