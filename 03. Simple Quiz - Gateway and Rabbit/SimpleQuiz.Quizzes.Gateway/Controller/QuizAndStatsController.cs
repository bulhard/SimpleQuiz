using AutoMapper;
using SimpleQuiz.Common.Controllers;
using SimpleQuiz.Quizzes.Gateway.Models.Quizzes;
using SimpleQuiz.Quizzes.Gateway.Services.Quizzes;
using SimpleQuiz.Quizzes.Gateway.Services.Statistics;
using System.Threading.Tasks;

namespace SimpleQuiz.Quizzes.Gateway.Controller
{
    public class QuizAndStatsController : ApiController
    {
        private readonly IQuizzesService quizzesService;
        private readonly IStatisticsService statisticsService;
        private readonly IMapper mapper;

        public QuizAndStatsController(IQuizzesService quizzesService, IStatisticsService statisticsService, IMapper mapper)
        {
            this.quizzesService = quizzesService;
            this.statisticsService = statisticsService;
            this.mapper = mapper;
        }

        public async Task<QuizzesAndStatsOutputModel> All()
        {
            var services = await quizzesService.All();

            var stats = await statisticsService.Full();

            var output = new QuizzesAndStatsOutputModel
            {
                Services = services,
                Statistics = stats
            };

            return output;
        }
    }
}