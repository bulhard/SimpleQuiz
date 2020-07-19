using Microsoft.AspNetCore.Mvc;
using SimpleQuiz.Common.Controllers;
using SimpleQuiz.Common.Services.Identity;
using SimpleQuiz.Quizzes.Models.People;
using SimpleQuiz.Quizzes.Models.Quizzes;
using SimpleQuiz.Quizzes.Services.Quizzes;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleQuiz.Quizzes.Controllers
{
    public class QuizzesController : ApiController
    {
        private readonly IQuizzesService quizzesService;
        private readonly ICurrentUserService currentUserService;

        public QuizzesController(IQuizzesService quizzesService, ICurrentUserService currentUserService)
        {
            this.quizzesService = quizzesService;
            this.currentUserService = currentUserService;
        }

        [HttpGet]
        public async Task<IEnumerable<QuizOutputModel>> All()
        {
            return await quizzesService.GetAll();
        }
    }
}