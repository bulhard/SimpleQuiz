using Microsoft.AspNetCore.Mvc;
using SimpleQuiz.Common.Controllers;
using SimpleQuiz.Statistics.Models.Statistics;
using SimpleQuiz.Statistics.Services.Statistics;
using System.Threading.Tasks;

namespace SimpleQuiz.Statistics.Controllers
{
    public class StatisticsController : ApiController
    {
        private readonly IStatisticsService statistics;

        public StatisticsController(IStatisticsService statistics)
            => this.statistics = statistics;

        [HttpGet]
        public async Task<StatisticsOutputModel> Full()
            => await this.statistics.Get();
    }
}