using System;
using System.ComponentModel.DataAnnotations;

namespace agenda_api.Entities
{
    public class UpdateBoardRequest
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public int TaskId { get; set; }
    }
}
