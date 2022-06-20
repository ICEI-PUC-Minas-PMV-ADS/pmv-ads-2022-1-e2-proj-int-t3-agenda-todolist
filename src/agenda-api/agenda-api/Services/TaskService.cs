using System;
using System.Collections.Generic;
using agenda_api.Entities;
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

        public TaskReponse SaveTask(Task task)
        {
            TaskReponse response;
            try
            {
                _taskRepository.SaveTask(task);
                response = new TaskReponse(task);
            }
            catch(Exception e)
            {
                throw e;
            }

            return response;
        }

        public List<TaskReponse> GetAllTasksByBoard(int boardId)
        {
            List<TaskReponse> response;
            try
            {
                List<Task> taskList = _taskRepository.GetAllTasksByBoard(boardId);
                response = taskList.ConvertAll(x => new TaskReponse(x));
            }
            catch (Exception e)
            {
                throw e;
            }

            return response;
        }

        public List<TaskReponse> GetAllTasksByUser(int userId)
        {
            List<TaskReponse> response;
            try
            {
                List<Task> taskList = _taskRepository.GetAllTasksByUser(userId);
                response = taskList.ConvertAll(x => new TaskReponse(x));
            }
            catch (Exception e)
            {
                throw e;
            }

            return response;
        }

        public List<TaskReponse> GetAll()
        {
            List<TaskReponse> response;
            try
            {
                List<Task> taskList = _taskRepository.GetAll();
                response = taskList.ConvertAll(x => new TaskReponse(x));
            }
            catch (Exception e)
            {
                throw e;
            }

            return response;
        }

        public TaskReponse GetById(int id)
        {
            TaskReponse response;
            try
            {
                Task task = _taskRepository.GetById(id);
                response = new TaskReponse(task);
            }
            catch (Exception e)
            {
                throw e;
            }

            return response;
        }

        public UpdateTaskRequest UpdateTask(int id, UpdateTaskRequest task)
        {
            try
            {
                _taskRepository.UpdateTask(id, task);
            }
            catch (Exception e)
            {
                throw e;
            }

            return task;
        }

        public int DeleteTask(int id)
        {
            try
            {
                _taskRepository.DeleteTask(id);
            }
            catch (Exception e)
            {
                throw e;
            }

            return id;
        }
    }
}
