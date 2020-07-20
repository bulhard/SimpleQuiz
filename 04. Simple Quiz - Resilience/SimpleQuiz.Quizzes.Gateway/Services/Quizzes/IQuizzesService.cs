using Refit;
using SimpleQuiz.Quizzes.Gateway.Models.Quizzes;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleQuiz.Quizzes.Gateway.Services.Quizzes
{
    public interface IQuizzesService
    {
        [Get("/Quizzes")]
        Task<IEnumerable<QuizOutputModel>> All();
    }
}