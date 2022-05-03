using System;
using System.Collections.Generic;

namespace agenda_api.Interfaces.Services
{
    public interface ITaskService
    {
        public Task SaveTask(Task task);
        public List<Task> GetAll();
    }
}
