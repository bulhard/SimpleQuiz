using SimpleQuiz.Common.Services;
using SimpleQuiz.Quizzes.Data.Models;
using SimpleQuiz.Quizzes.Models.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleQuiz.Quizzes.Services.People
{
    public interface IPeopleService : IDataService<Person>
    {
        Task<Person> FindByUser(string userId);

        Task<Person> FindById(int id);

        Task<int> GetIdByUser(string userId);

        Task<bool> HasQuizzes(int personId, int quizId);

        Task<bool> IsPerson(string userId);

        Task<IEnumerable<PersonDetailsOutputModel>> GetAll();

        Task<PersonDetailsOutputModel> GetDetails(int id);
    }
}