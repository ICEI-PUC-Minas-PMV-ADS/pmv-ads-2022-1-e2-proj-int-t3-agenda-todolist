using System;
using System.Collections.Generic;
using agenda_api.Entities;

namespace agenda_api.Interfaces.Services
{
    public interface ITaskService
    {
        public Task SaveTask(Task task);
        public List<Task> GetAll();
        public List<Task> GetAllTasksByUser(int userId);
        public Task GetById(int id);
        public UpdateTaskRequest UpdateTask(int id, UpdateTaskRequest task);
        public int DeleteTask(int id);
    }
}
