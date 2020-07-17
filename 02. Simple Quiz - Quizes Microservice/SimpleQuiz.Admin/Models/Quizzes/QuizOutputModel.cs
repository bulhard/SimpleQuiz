namespace SimpleQuiz.Admin.Models.Quizzes
{
    public class QuizOutputModel
    {
        public long Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int TotalQuestionsCount { get; set; }
    }
}