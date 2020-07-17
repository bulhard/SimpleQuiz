using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SimpleQuiz.Common.Controllers;
using SimpleQuiz.Common.Services;
using SimpleQuiz.Common.Services.Identity;
using SimpleQuiz.Quizzes.Data.Models;
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
        public async Task<ActionResult<int>> GetPersonId()
        {
            var userId = this.currentUserService.UserId;

            var userIsPerson = await this.peopleService.IsPerson(userId);

            if (!userIsPerson)
            {
                return this.BadRequest("This user is not a person.");
            }

            return await this.peopleService.GetIdByUser(this.currentUserService.UserId);
        }

        [HttpPut]
        [Route("Create")]
        [Authorize]
        public async Task<ActionResult<int>> Create(PersonInputModel personInputModel)
        {
            var newPerson = new Person
            {
                FirstName = personInputModel.FirstName,
                LastName = personInputModel.LastName,
                UserId = personInputModel.UserId
            };

            await this.peopleService.Save(newPerson);

            return newPerson.Id;
        }

        [HttpPut]
        [Route(Id)]
        public async Task<ActionResult> Edit(int id, PersonInputModel personInputModel)
        {
            var person = await this.peopleService.FindById(id);

            if (person == null)
            {
                return BadRequest(Result.Failure("There is no such person."));
            }

            person.FirstName = personInputModel.FirstName;
            person.LastName = personInputModel.LastName;

            await this.peopleService.Save(person);

            return Ok();
        }
    }
}