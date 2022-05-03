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
            string values = $" '{task.Name}', '{task.Description}', '{task.CreatedDate}', '{task.TodoDate}' ";
            try
            {
                base.insertData(TASKPARAMETERS, values);
            }
            catch(Exception e)
            {
                throw e;
            }

            return task;
        }
    }
}
