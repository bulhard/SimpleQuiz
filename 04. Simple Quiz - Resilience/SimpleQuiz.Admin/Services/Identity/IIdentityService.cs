using Refit;
using SimpleQuiz.Admin.Models.Identity;
using System.Threading.Tasks;

namespace SimpleQuiz.Admin.Services.Identity
{
    public interface IIdentityService
    {
        [Post("/Identity/Login")]
        Task<UserOutputModel> Login([Body] UserInputModel loginInput);
    }
}