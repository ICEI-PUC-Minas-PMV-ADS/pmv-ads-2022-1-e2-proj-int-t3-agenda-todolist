using System;
using System.Collections.Generic;
using agenda_api.Interfaces.Repository;
using agenda_api.Interfaces.Services;

namespace agenda_api.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;
         
        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public Task SaveTask(Task task)
        {
            try
            {
                _taskRepository.SaveTask(task);
            }
            catch(Exception e)
            {
                throw e;
            }

            return task;
        }

        public List<Task> GetAll()
        {
            List<Task> taskListk;
            try
            {
                taskListk = _taskRepository.GetAll();
            }
            catch (Exception e)
            {
                throw e;
            }

            return taskListk;
        }
    }
}
