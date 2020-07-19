using Microsoft.AspNetCore.Authorization;

namespace SimpleQuiz.Common.Infrastructure
{
    public class AuthorizeAdministratorAttribute : AuthorizeAttribute
    {
        public AuthorizeAdministratorAttribute() => this.Roles = Constants.AdministratorRoleName;
    }
}