using Refit;
using SimpleQuiz.Admin.Models.People;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleQuiz.Admin.Services.People
{
    public interface IPeopleService
    {
        [Get("/People")]
        Task<IEnumerable<PersonDetailsOutputModel>> All();

        [Get("/People/{id}")]
        Task<PersonDetailsOutputModel> Details(int id);

        [Put("/People/{id}")]
        Task Edit(int? id, PersonInputModel dealer);
    }
}