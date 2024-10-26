using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OverrideConfigUsingFuentApi.Entities;

namespace OverrideConfigUsingFuentApi.Data
{
    internal class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Tweet> Tweets { get; set; } = null!;
        public DbSet<Comment> Comments { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().ToTable("tblUsers");
            modelBuilder.Entity<Tweet>().ToTable("tblTweets");
            modelBuilder.Entity<Comment>().ToTable("tblComments");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var config = new ConfigurationBuilder().AddJsonFile("appSettings.json").Build();
            var constr = config.GetSection("constr").Value;
            optionsBuilder.UseSqlServer(constr);

        }
    }
}
