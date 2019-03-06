using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        [StringLength(6, ErrorMessage="You must use a strong username between 3 and 6 characters tops", MinimumLength=3)]
        public string Username { get; set; }

        [Required]
        [StringLength(100, ErrorMessage="You must specify password between 4 and 8 characters", MinimumLength=4)]
        public string Password { get; set; }
    }
}