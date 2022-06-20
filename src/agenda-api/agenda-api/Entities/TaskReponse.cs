using System;
namespace agenda_api.Entities
{
    public class TaskReponse
    {
        public TaskReponse(Task task)
        {
            Id = task.Id;
            Name = task.Name;
            Description = task.Description;
            UserId = task.user_id;
            BoardId = task.board_id;
            CreatedDate = task.CreatedDate;
            TodoDate = task.TodoDate;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int UserId { get; set; }

        public int BoardId { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime TodoDate { get; set; }
    }
}
