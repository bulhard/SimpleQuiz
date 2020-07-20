using System.ComponentModel.DataAnnotations;

using static SimpleQuiz.Identity.Data.DataConstants.Identity;

namespace SimpleQuiz.Identity.Models.Identity
{
    public class UserInputModel
    {
        [EmailAddress]
        [Required]
        [MinLength(MinEmailLength)]
        [MaxLength(MaxEmailLength)]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}