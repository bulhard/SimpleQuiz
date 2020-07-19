using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleQuiz.Quizzes.Data.Models;

using static SimpleQuiz.Quizzes.Data.DataConstants.Common;

namespace SimpleQuiz.Quizzes.Data.Configuration
{
    internal class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder
                .HasKey(d => d.Id);

            builder
                .Property(d => d.Title)
                .IsRequired()
                .HasMaxLength(MaxTitleLength);

            builder
                .Property(d => d.Text)
                .IsRequired()
                .HasMaxLength(MaxTextLength);

            builder
                .HasOne(d => d.Quiz)
                .WithMany(c => c.Questions)
                .HasForeignKey(c => c.QuizId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}