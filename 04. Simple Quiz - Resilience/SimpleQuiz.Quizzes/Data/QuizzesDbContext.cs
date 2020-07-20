using Microsoft.EntityFrameworkCore;
using SimpleQuiz.Quizzes.Data.Models;
using System.Reflection;

namespace SimpleQuiz.Quizzes.Data
{
    public class QuizzesDbContext : DbContext
    {
        public QuizzesDbContext(DbContextOptions<QuizzesDbContext> options) : base(options)
        {
        }

        public DbSet<Person> People { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<Answer> Answers { get; set; }

        public DbSet<Quiz> Quizzes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}