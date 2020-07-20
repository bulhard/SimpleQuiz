using SimpleQuiz.Common.Services;
using SimpleQuiz.Quizzes.Data.Models;
using SimpleQuiz.Quizzes.Models.Quizzes;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleQuiz.Quizzes.Services.Quizzes
{
    public interface IQuizzesService : IDataService<Quiz>
    {
        Task<Quiz> Find(int quizId);

        Task<IEnumerable<QuizOutputModel>> GetAll();
    }
}