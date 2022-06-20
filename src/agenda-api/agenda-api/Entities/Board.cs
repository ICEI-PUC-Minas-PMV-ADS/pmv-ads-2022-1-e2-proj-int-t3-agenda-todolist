using System;
using System.ComponentModel.DataAnnotations;

namespace agenda_api.Entities
{
    public class Board : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
