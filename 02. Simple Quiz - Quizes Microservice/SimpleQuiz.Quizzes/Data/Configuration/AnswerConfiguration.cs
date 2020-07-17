using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleQuiz.Quizzes.Data.Models;

using static SimpleQuiz.Quizzes.Data.DataConstants.Common;

namespace SimpleQuiz.Quizzes.Data.Configuration
{
    internal class AnswerConfiguration : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            builder
                .HasKey(d => d.Id);

            builder
                .Property(d => d.Text)
                .IsRequired()
                .HasMaxLength(MaxTextLength);

            builder
                .Property(d => d.Points)
                .IsRequired();

            builder
                .HasOne(d => d.Question)
                .WithMany(c => c.Answers)
                .HasForeignKey(c => c.QuestionId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}