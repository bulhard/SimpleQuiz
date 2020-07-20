using Refit;
using SimpleQuiz.Quizzes.Gateway.Models.Statistics;
using System.Threading.Tasks;

namespace SimpleQuiz.Quizzes.Gateway.Services.Statistics
{
    public interface IStatisticsService
    {
        [Get("/Statistics")]
        Task<StatisticsOutputModel> Full();
    }
}