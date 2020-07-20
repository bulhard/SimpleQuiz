using SimpleQuiz.Common.Models;
using SimpleQuiz.Statistics.Data.Models;

namespace SimpleQuiz.Statistics.Models.Statistics
{
    public class StatisticsOutputModel : IMapFrom<Statistic>
    {
        public int TotalPeople { get; set; }

        public int TotalQuizzes { get; set; }
    }
}