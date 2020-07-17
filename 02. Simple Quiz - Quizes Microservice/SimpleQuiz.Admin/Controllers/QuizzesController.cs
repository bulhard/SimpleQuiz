using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SimpleQuiz.Admin.Services.Quizzes;
using System.Threading.Tasks;

namespace SimpleQuiz.Admin.Controllers
{
    public class QuizzesController : AdministrationController
    {
        #region Fields and Construtors

        private readonly IMapper mapper;
        private readonly IQuizzesService quizzesService;

        public QuizzesController(IMapper mapper, IQuizzesService quizzesService)
        {
            this.mapper = mapper;
            this.quizzesService = quizzesService;
        }

        #endregion Fields and Construtors

        public async Task<IActionResult> Index()
        {
            var result = await this.quizzesService.All();

            return View(result);
        }
    }
}