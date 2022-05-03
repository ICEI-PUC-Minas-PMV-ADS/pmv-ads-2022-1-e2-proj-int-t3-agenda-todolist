using System;
using System.Collections.Generic;

namespace agenda_api.Interfaces.Repository
{
    public interface ITaskRepository
    {
        public List<Task> GetAll();
        public Task GetTaskByID(string id);
        public Task SaveTask(Task task);
        public Task UpdateTask(int id, Task task);
        public int DeleteTask(int id);
    }
}
