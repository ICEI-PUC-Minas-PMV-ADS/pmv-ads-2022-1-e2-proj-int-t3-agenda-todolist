using System;
using System.ComponentModel.DataAnnotations;

namespace agenda_api.Entities
{
    public class UserRequest
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }

}
