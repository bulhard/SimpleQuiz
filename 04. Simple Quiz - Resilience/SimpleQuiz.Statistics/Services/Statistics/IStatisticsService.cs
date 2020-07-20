using SimpleQuiz.Statistics.Models.Statistics;
using System.Threading.Tasks;

namespace SimpleQuiz.Statistics.Services.Statistics
{
    public interface IStatisticsService
    {
        Task<StatisticsOutputModel> Get();

        Task AddPerson();

        Task AddQuiz();
    }
}