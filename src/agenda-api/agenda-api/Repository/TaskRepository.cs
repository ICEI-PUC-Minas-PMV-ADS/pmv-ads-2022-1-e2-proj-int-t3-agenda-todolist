using System;
using System.Collections.Generic;
using agenda_api.Entities;
using agenda_api.Interfaces.Repository;

namespace agenda_api.Repository
{
    public class TaskRepository : BaseRepository<Task>, ITaskRepository
    {
        private string TABLENAME = "Task";
        private string PARAMETERS = "Name, Description, Status, CreatedDate, TodoDate";

        public TaskRepository()
        {
            base._tableName = TABLENAME;
        }

        public List<Task> GetAll()
        {
            return base.getData("*");
        }

        public List<Task> GetAllTasksByUser(int userId)
        {
            string condition = $"WHERE user_id='{userId}'";
            return base.getData("*", condition);
        }

        public List<Task> GetAllTasksByBoard(int boardId)
        {
            string condition = $"WHERE board_id='{boardId}'";
            return base.getData("*", condition);
        }

        public Task GetById(int id)
        {
            string condition = $"WHERE id={id}";
            return base.getData("*", condition)[0];
        }

        public Task SaveTask(Task task)
        {
            int taskId;
            task.CreatedDate = new DateTime();
            string values = $" '{task.Name}', '{task.Description}', '{task.Status}', '{task.CreatedDate}', '{task.TodoDate}' ";
            try
            {
                taskId = base.insertData(PARAMETERS, values);
            }
            catch(Exception e)
            {
                throw e;
            }
            task.Id = taskId;
            return task;
        }

        public TaskRequest UpdateTask(int id, TaskRequest task)
        {

            string values = $" Name= '{task.Name}', Description = '{task.Description}',Status = '{task.Status}', TodoDate = '{task.TodoDate}'";

            if (task.BoardId != 0 && task.UserId != 0)
            {
                values = $" Name= '{task.Name}', Description = '{task.Description}', Status = '{task.Status}', TodoDate = '{task.TodoDate}', user_id = '{task.UserId}', board_id = '{task.BoardId}' ";
            }
            else if (task.BoardId != 0)
            {
                values = $" Name= '{task.Name}', Description = '{task.Description}', Status = '{task.Status}', TodoDate = '{task.TodoDate}', board_id = '{task.BoardId}' ";
            }
            else if (task.UserId != 0)
            {
                values = $" Name= '{task.Name}', Description = '{task.Description}', Status = '{task.Status}', TodoDate = '{task.TodoDate}', user_id = '{task.UserId}' ";
            }

            try
            {
                base.updateData(id, values);
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
                base.deleteData($"'{id}'");
            }
            catch (Exception e)
            {
                throw e;
            }

            return id;
        }
    }
}
