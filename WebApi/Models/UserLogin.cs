using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class UserLogin
    {
        [Required]
        [MinLength(3, ErrorMessage = "Username must be more than 3 characters long.")]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
