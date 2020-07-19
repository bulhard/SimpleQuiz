using SimpleQuiz.Common.Services;
using SimpleQuiz.Statistics.Data.Models;
using System.Linq;

namespace SimpleQuiz.Statistics.Data
{
    public class StatisticsDataSeeder : IDataSeeder
    {
        private readonly StatisticsDbContext db;

        public StatisticsDataSeeder(StatisticsDbContext db) => this.db = db;

        public void SeedData()
        {
            if (this.db.Statistics.Any())
            {
                return;
            }

            this.db.Statistics.Add(new Statistic
            {
                TotalPeople = 0,
                TotalQuizzes = 0
            });

            this.db.SaveChanges();
        }
    }
}