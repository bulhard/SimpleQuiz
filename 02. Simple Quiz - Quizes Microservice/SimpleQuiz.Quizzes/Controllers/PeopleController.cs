using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SimpleQuiz.Common.Controllers;
using SimpleQuiz.Common.Services.Identity;
using SimpleQuiz.Quizzes.Models.People;
using SimpleQuiz.Quizzes.Services.People;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleQuiz.Quizzes.Controllers
{
    public class PeopleController : ApiController
    {
        #region Fields and Construtors

        private readonly IPeopleService peopleService;
        private readonly ICurrentUserService currentUserService;

        public PeopleController(IPeopleService peopleService, ICurrentUserService currentUserService)
        {
            this.peopleService = peopleService;
            this.currentUserService = currentUserService;
        }

        #endregion Fields and Construtors

        [HttpGet]
        public async Task<IEnumerable<PersonDetailsOutputModel>> All()
        {
            return await peopleService.GetAll();
        }

        [HttpGet]
        [Route(Id)]
        public async Task<ActionResult<PersonDetailsOutputModel>> Details(int id)
        {
            return await peopleService.GetDetails(id);
        }

        [HttpGet]
        [Authorize]
        [Route("Id")]
        public async Task<ActionResult<int>> GetDealerId()
        {
            var userId = this.currentUserService.UserId;

            var userIsDealer = await this.peopleService.IsPerson(userId);

            if (!userIsDealer)
            {
                return this.BadRequest("This user is not a person.");
            }

            return await this.peopleService.GetIdByUser(this.currentUserService.UserId);
        }
    }
}