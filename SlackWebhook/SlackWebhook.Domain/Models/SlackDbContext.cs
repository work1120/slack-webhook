using Microsoft.EntityFrameworkCore;
using SlackWebhook.Domain.Models.Entity;
using SlackWebhook.Domain.Util;

namespace SlackWebhook.Domain.Models
{
    public class SlackDbContext : DbContext
    {
        public SlackDbContext() : base(new DbContextOptionsBuilder().UseSqlServer(Configuration.DbConnectionString()).Options)
        {
        }

        public DbSet<UserEntity> UserEntity { get; set; }
    }
}
