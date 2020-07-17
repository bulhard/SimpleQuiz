using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SimpleQuiz.Admin.Models.People;
using SimpleQuiz.Admin.Services.People;
using System.Threading.Tasks;

namespace SimpleQuiz.Admin.Controllers
{
    public class PeopleController : AdministrationController
    {
        #region Fields and Construtors

        private readonly IMapper mapper;
        private readonly IPeopleService peopleService;

        public PeopleController(IMapper mapper, IPeopleService peopleService)
        {
            this.mapper = mapper;
            this.peopleService = peopleService;
        }

        #endregion Fields and Construtors

        public async Task<IActionResult> Index()
        {
            var result = await peopleService.All();

            return View(result);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id != null)
            {
                var person = await peopleService.Details(id);

                var personFormModel = mapper.Map<PersonFormModel>(person);

                return View(personFormModel);
            }
            else
            {
                return View(new PersonFormModel());
            }
        }

        [HttpPost]
        public async Task<IActionResult> Details(int? id, PersonFormModel model)
        {
            if (id == null)
            {
                return await this.Handle(
                                  async () =>
                                  {
                                      await peopleService.Create(mapper.Map<PersonInputModel>(model));
                                  },
                                  success: RedirectToAction(nameof(Index)),
                                  failure: View(model));
            }
            else
            {
                return await this.Handle(
                              async () =>
                              {
                                  await peopleService.Edit(id, mapper.Map<PersonInputModel>(model));
                              },
                              success: RedirectToAction(nameof(Index)),
                              failure: View(model));
            }
        }
    }
}