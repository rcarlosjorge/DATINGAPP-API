using System;
using System.ComponentModel.DataAnnotations;

namespace DatingApp_API.DTOS
{
    public class RegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}

