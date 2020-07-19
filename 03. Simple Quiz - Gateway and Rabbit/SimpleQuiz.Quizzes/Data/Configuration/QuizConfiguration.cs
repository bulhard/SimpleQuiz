using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleQuiz.Quizzes.Data.Models;

using static SimpleQuiz.Quizzes.Data.DataConstants.Common;

namespace SimpleQuiz.Quizzes.Data.Configuration
{
    internal class QuizConfiguration : IEntityTypeConfiguration<Quiz>
    {
        public void Configure(EntityTypeBuilder<Quiz> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .Property(m => m.Title)
                .IsRequired()
                .HasMaxLength(MaxTitleLength);

            builder
                .Property(m => m.Description)
                .IsRequired()
                .HasMaxLength(MaxTitleLength);

            builder
                .Property(m => m.PersonId);
        }
    }
}