using System;
using System.Collections.Generic;

namespace agenda_api.Interfaces.Services
{
    public interface ITaskService
    {
        public Task SaveTask(Task task);
        public List<Task> GetAll();
        public Task GetById(int id);
        public Task UpdateTask(int id, Task task);
        public int DeleteTask(int id);
    }
}
