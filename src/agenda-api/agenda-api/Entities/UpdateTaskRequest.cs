using System;
using System.ComponentModel.DataAnnotations;

namespace agenda_api.Entities
{
    public class UpdateTaskRequest
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "mm/dd/yyyy")]
        public DateTime TodoDate { get; set; }

        public int UserId { get; set; }

        public int BoardId { get; set; }
    }
}
