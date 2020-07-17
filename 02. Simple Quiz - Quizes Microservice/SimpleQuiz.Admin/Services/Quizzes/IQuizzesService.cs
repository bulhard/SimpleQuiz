using Refit;
using SimpleQuiz.Admin.Models.Quizzes;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleQuiz.Admin.Services.Quizzes
{
    public interface IQuizzesService
    {
        [Get("/Quizzes")]
        Task<IEnumerable<QuizOutputModel>> All();
    }
}