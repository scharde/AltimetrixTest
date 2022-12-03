using Microsoft.EntityFrameworkCore;
using TestProject.Data.Entity;

namespace TestProject.Repository
{
    public class ZipContext : DbContext
    {
        public ZipContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<UserEntity> Users { get; set; }
        public DbSet<AccountEntity> Accounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserEntity>().HasIndex(u => u.Email).IsUnique();
        }
    }
}
