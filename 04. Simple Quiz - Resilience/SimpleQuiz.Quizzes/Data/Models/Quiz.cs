using System.Collections.Generic;

namespace SimpleQuiz.Quizzes.Data.Models
{
    public class Quiz
    {
        public long Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public List<Question> Questions { get; set; }

        public int? PersonId { get; set; }

        public Person Person { get; set; }
    }
}