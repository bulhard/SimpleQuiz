using SimpleQuiz.Quizzes.Gateway.Models.Statistics;
using System.Collections.Generic;

namespace SimpleQuiz.Quizzes.Gateway.Models.Quizzes
{
    public class QuizzesAndStatsOutputModel
    {
        public IEnumerable<QuizOutputModel> Quizzes { get; set; }
        public StatisticsOutputModel Statistics { get; set; }
    }
}