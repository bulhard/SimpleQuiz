using SimpleQuiz.Identity.Data.Models;
using System.Collections.Generic;

namespace SimpleQuiz.Identity.Services.Identity
{
    public interface ITokenGeneratorService
    {
        string GenerateToken(User user, IEnumerable<string> roles = null);
    }
}