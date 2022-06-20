using System;
using agenda_api.Entities;
using System.ComponentModel.DataAnnotations;

namespace agenda_api.Entities
{
    public class User : BaseEntity
    {
        public int User_id { get; set; }

        [Required]
        public string User_type { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
