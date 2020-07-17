using SimpleQuiz.Common.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SimpleQuiz.Admin.Models.People
{
    public class PersonFormModel : IMapFrom<PersonDetailsOutputModel>
    {
        [Required]
        [DisplayName("First name")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Last name")]
        public string LastName { get; set; }
    }
}