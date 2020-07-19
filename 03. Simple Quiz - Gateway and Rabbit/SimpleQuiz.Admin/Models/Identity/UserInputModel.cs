using SimpleQuiz.Common.Models;

namespace SimpleQuiz.Admin.Models.Identity
{
    public class UserInputModel : IMapFrom<LoginFormModel>
    {
        public string Email { get; set; }

        public string Password { get; set; }
    }
}