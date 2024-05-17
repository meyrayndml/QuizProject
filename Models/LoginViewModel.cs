using System.ComponentModel.DataAnnotations;

namespace MyQuizProject.Models
{
    public class LoginViewModel
    {
        public class ApplicationUser
        {
            [Key]
            public int Id { get; set; }

            [Required]
            public string Username { get; set; }

            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }
        }
    }
}
