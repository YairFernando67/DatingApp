using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        [EmailAddress]
        public string Username { get; set; }

        [Required]
        [StringLength(100, ErrorMessage="You must specify password between 4 and 8 characters", MinimumLength=4)]
        public string Password { get; set; }
    }
}