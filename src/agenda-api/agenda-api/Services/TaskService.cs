﻿using System;
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

        public List<Task> GetAllTasksByUser(int userId)
        {
            List<Task> taskListk;
            try
            {
                taskListk = _taskRepository.GetAllTasksByUser(userId);
            }
            catch (Exception e)
            {
                throw e;
            }

            return taskListk;
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

        public Task GetById(int id)
        {
            Task task;
            try
            {
                task = _taskRepository.GetById(id);
            }
            catch (Exception e)
            {
                throw e;
            }

            return task;
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
