using System.Collections.Generic;

namespace SimpleQuiz.Quizzes.Data.Models
{
    public class Question
    {
        public long Id { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }

        public long QuizId { get; set; }

        public Quiz Quiz { get; set; }

        public List<Answer> Answers { get; set; }
    }
}