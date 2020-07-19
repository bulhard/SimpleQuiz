using SimpleQuiz.Common.Models;

namespace SimpleQuiz.Admin.Models.People
{
    public class PersonInputModel : IMapFrom<PersonFormModel>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserId { get; set; }
    }
}