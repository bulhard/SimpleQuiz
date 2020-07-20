using System.Collections.Generic;

namespace SimpleQuiz.Admin.Models.Quizzes
{
    public class QuizzesAndStatsOutputModel
    {
        public IEnumerable<QuizOutputModel> Quizzes { get; set; }
        public StatisticsOutputModel Statistics { get; set; }
    }
}