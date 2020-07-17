using SimpleQuiz.Common.Models;
using SimpleQuiz.Quizzes.Data.Models;

namespace SimpleQuiz.Quizzes.Models.People
{
    public class PersonOutputModel : IMapFrom<Person>
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}