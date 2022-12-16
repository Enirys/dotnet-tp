using CarthageCRUD.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CarthageCRUD.Data
{
    public class MVCDbContext : DbContext
    {
        public MVCDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Concert> Concerts { get; set; }
    }
}
