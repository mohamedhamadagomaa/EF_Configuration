using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OverrideConfigByGroupingConfiguration.Data.Config;
using OverrideConfigByGroupingConfiguration.Entities;

namespace OverrideConfigByGroupingConfiguration.Data
{
    internal class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Tweet> Tweets { get; set; } = null!;
        public DbSet<Comment> Comments { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new UserConfig().Configure(modelBuilder.Entity<User>());
            new TweetConfig().Configure(modelBuilder.Entity<Tweet>());
            new CommentConfig().Configure(modelBuilder.Entity<Comment>());
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
