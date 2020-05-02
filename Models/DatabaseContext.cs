
using Microsoft.EntityFrameworkCore;

namespace WeddingPlanner.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users {get;set;}
        public DbSet<Wedding> Weddings {get;set;}
        public DbSet<Relation> Relations { get; set; }

    }
}