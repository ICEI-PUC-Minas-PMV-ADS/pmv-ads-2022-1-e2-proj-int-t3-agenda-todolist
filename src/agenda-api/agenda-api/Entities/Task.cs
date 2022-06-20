using System;
using agenda_api.Entities;
using System.ComponentModel.DataAnnotations;


namespace agenda_api
{
    public class Task : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public int UserId { get; set; }

        [DisplayFormat(DataFormatString = "mm/dd/yyyy")]
        public DateTime CreatedDate { get; set; }

        [DisplayFormat(DataFormatString = "mm/dd/yyyy")]
        public DateTime TodoDate { get; set; }

    }
}
