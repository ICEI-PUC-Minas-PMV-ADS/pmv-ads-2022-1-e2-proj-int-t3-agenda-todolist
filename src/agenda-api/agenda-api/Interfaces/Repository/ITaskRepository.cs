using System;
using System.Collections.Generic;
using agenda_api.Entities;

namespace agenda_api.Interfaces.Repository
{
    public interface ITaskRepository
    {
        public List<Task> GetAll();
        public Task GetById(int id);
        public Task SaveTask(Task task);
        public List<Task> GetAllTasksByUser(int userId);
        public List<Task> GetAllTasksByBoard(int boardId);
        public UpdateTaskRequest UpdateTask(int id, UpdateTaskRequest task);
        public int DeleteTask(int id);
    }
}
