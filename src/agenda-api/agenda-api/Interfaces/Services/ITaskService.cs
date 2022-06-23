using System;
using System.Collections.Generic;
using agenda_api.Entities;

namespace agenda_api.Interfaces.Services
{
    public interface ITaskService
    {
        public TaskReponse SaveTask(Task task);
        public List<TaskReponse> GetAll();
        public List<TaskReponse> GetAllTasksByUser(int userId);
        public List<TaskReponse> GetAllTasksByBoard(int boardId);
        public TaskReponse GetById(int id);
        public TaskRequest UpdateTask(int id, TaskRequest task);
        public int DeleteTask(int id);
    }
}
