using Refit;
using SimpleQuiz.Admin.Models.Quizzes;
using System.Threading.Tasks;

namespace SimpleQuiz.Admin.Services.Quizzes
{
    public interface IQuizzesGatewayService
    {
        [Get("/QuizAndStats")]
        Task<QuizzesAndStatsOutputModel> All();
    }
}