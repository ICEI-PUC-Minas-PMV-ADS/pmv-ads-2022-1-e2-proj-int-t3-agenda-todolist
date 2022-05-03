using System;
using System.Collections.Generic;
using agenda_api.Interfaces.Repository;

namespace agenda_api.Repository
{
    public class TaskRepository : BaseRepository<Task>, ITaskRepository
    {
        private string TABLENAME = "Task";
        private string TASKPARAMETERS = "Name, Description, CreatedDate, TodoDate";

        public TaskRepository()
        {
            base._tableName = TABLENAME;
        }

        public List<Task> GetAll()
        {
            return base.getData("*");
        }

        public Task GetTaskByID(string id)
        {
            string condition = $"WHERE ID={id}";
            return base.getData("*", condition)[0];
        }

        public Task SaveTask(Task task)
        {
            int taskId;
            task.CreatedDate = new DateTime();
            string values = $" '{task.Name}', '{task.Description}', '{task.CreatedDate}', '{task.TodoDate}' ";
            try
            {
                taskId = base.insertData(TASKPARAMETERS, values);
            }
            catch(Exception e)
            {
                throw e;
            }
            task.Id = taskId;
            return task;
        }

        public Task UpdateTask(int id, Task task)
        {
            string values = $" Name= '{task.Name}', Description = '{task.Description}', TodoDate = '{task.TodoDate}' ";
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
