namespace SimpleQuiz.Quizzes.Data.Models
{
    public class Answer
    {
        public long Id { get; set; }

        public string Text { get; set; }

        public int Points { get; set; }

        public long QuestionId { get; set; }

        public Question Question { get; set; }
    }
}