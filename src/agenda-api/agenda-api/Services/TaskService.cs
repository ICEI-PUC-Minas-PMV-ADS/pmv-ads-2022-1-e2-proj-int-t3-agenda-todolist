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
        private readonly IUserRepository _userRepository;
        private readonly IBoardRepository _boardRepository;

        public TaskService(ITaskRepository taskRepository, IUserRepository userRepository, IBoardRepository boardRepository)
        {
            _taskRepository = taskRepository;
            _userRepository = userRepository;
            _boardRepository = boardRepository;
        }

        public TaskReponse SaveTask(Task task)
        {
            TaskReponse response;
            try
            {
                if (task.user_id != 0)
                {
                    try
                    {
                        User user = _userRepository.GetById(task.user_id);
                    }
                    catch (Exception e)
                    {
                        throw new Exception("Nenhum usuário encontrado");
                    }
                }

                if (task.board_id != 0)
                {

                    try
                    {
                        Board board = _boardRepository.GetById(task.board_id);
                    }
                    catch (Exception e)
                    {
                        throw new Exception("Nenhum board encontrado");
                    }
                }
                

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
            List<TaskReponse> response = new List<TaskReponse>(); 
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
            List<TaskReponse> response = new List<TaskReponse>();
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
            List<TaskReponse> response = new List<TaskReponse>();
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

        public TaskRequest UpdateTask(int id, TaskRequest task)
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
