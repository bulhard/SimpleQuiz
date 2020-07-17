using SimpleQuiz.Common.Services;
using SimpleQuiz.Identity.Data.Models;
using SimpleQuiz.Identity.Models.Identity;
using System.Threading.Tasks;

namespace SimpleQuiz.Identity.Services.Identity
{
    public interface IIdentityService
    {
        Task<Result<User>> Register(UserInputModel userInput);

        Task<Result<UserOutputModel>> Login(UserInputModel userInput);

        Task<Result> ChangePassword(string userId, ChangePasswordInputModel changePasswordInput);
    }
}