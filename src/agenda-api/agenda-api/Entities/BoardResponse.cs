using System;
using System.Collections.Generic;

namespace agenda_api.Entities
{
    public class BoardResponse
    {
        public BoardResponse(Board board, List<TaskReponse> tasks)
        {
            Id = board.Id;
            Name = board.Name;
            Description = board.Description;
            Tasks = tasks;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<TaskReponse> Tasks { get; set; }
    }
}
