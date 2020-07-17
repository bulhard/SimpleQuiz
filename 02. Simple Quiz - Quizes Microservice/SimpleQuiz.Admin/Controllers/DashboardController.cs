using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SimpleQuiz.Admin.Services.Quizzes;

namespace SimpleQuiz.Admin.Controllers
{
    public class DashboardController : AdministrationController
    {
        #region Fields and Construtors

        private readonly IMapper mapper;
        private readonly IQuizzesService quizzesService;

        public DashboardController(IMapper mapper, IQuizzesService quizzesService)
        {
            this.mapper = mapper;
            this.quizzesService = quizzesService;
        }

        #endregion Fields and Construtors

        public IActionResult Index()
        {
            return View();
        }
    }
}