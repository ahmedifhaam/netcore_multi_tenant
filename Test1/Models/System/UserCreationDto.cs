using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test1.Models.System
{
    public class UserCreationDto
    {

        [Required]
        [MaxLength(30)]
        public string Username { get; set; }

        [MaxLength(100)]
        [Required]
        public string Password { get; set; }

        [Required]
        public int ClientEntityId { get; set; }
    }
}
