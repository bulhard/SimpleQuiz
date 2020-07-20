using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SimpleQuiz.Admin.Services.Quizzes;
using System.Threading.Tasks;

namespace SimpleQuiz.Admin.Controllers
{
    public class DashboardController : AdministrationController
    {
        #region Fields and Construtors

        private readonly IMapper mapper;
        private readonly IQuizzesGatewayService quizzesGatewayService;

        public DashboardController(IMapper mapper, IQuizzesGatewayService quizzesGatewayService)
        {
            this.mapper = mapper;
            this.quizzesGatewayService = quizzesGatewayService;
        }

        #endregion Fields and Construtors

        public async Task<IActionResult> Index()
        {
            return View(await quizzesGatewayService.All());
        }
    }
}