using System.ComponentModel.DataAnnotations;
using System;

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

        [Required]
        public string Gender { get; set; }

        [Required]
        public string KnowAs { get; set; }         

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Country { get; set; }
        
        public DateTime Created { get; set; }

        public DateTime LastActive { get; set; }

        public UserForRegisterDto()
        {
            Created = DateTime.Now;
            LastActive = DateTime.Now;
        }

        
    }
}