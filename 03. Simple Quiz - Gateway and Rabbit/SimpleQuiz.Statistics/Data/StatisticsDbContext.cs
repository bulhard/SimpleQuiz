using Microsoft.EntityFrameworkCore;
using SimpleQuiz.Statistics.Data.Models;
using System.Reflection;

namespace SimpleQuiz.Statistics.Data
{
    public class StatisticsDbContext : DbContext
    {
        public StatisticsDbContext(DbContextOptions<StatisticsDbContext> options)
            : base(options)
        {
        }

        public DbSet<Statistic> Statistics { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}