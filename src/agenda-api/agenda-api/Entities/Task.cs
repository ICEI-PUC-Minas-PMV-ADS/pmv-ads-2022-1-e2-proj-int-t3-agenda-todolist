using System;
using agenda_api.Entities;
using System.ComponentModel.DataAnnotations;


namespace agenda_api
{
    public class Task : BaseEntity
    {
        public Task()
        {

        }

        public Task(TaskRequest taskRequest)
        {
            Name = taskRequest.Name;
            Description = taskRequest.Description;
            this.user_id = taskRequest.UserId;
            this.board_id = taskRequest.BoardId;
            TodoDate = taskRequest.TodoDate;
        }

        public Task(int id, string name, string description, DateTime createdDate, DateTime todoDate)
        {
            Id = id;
            Name = name;
            Description = description;
            CreatedDate = createdDate;
            TodoDate = todoDate;
        }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public int user_id { get; set; }

        public int board_id { get; set; }

        [DisplayFormat(DataFormatString = "mm/dd/yyyy")]
        public DateTime CreatedDate { get; set; }

        [DisplayFormat(DataFormatString = "mm/dd/yyyy")]
        public DateTime TodoDate { get; set; }

        public static explicit operator Task(TaskRequest v)
        {
            return new Task(v);
        }
    }
}
