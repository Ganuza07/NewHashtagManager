using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NewHashtagManager.Domain.Entities.Models;

namespace NewHashtagManager.Domain.Context
{
    public class Context : DbContext, IHashtagContext
    {
        private readonly IConfiguration _config;
        public Context(IConfiguration config)
        {
            _config = config;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("Hashdb"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Posteo>().HasOne(x => x.User).WithMany(x => x.PostsList);
        }
        public DbSet<Posteo> Posts { get; set; }
        public DbSet<User> Users { get; set; }
    }
}