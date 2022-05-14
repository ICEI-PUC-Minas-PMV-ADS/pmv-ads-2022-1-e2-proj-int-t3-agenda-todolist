using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using agenda_api.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Web;
using agenda_api.Entities;

namespace agenda_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService _taskService;
        private readonly ILogger<TaskController> _logger;

        public TaskController(ITaskService taskService, ILogger<TaskController> logger)
        {
            _taskService = taskService;
            _logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(typeof(Task), StatusCodes.Status200OK)]
        public ActionResult<List<Task>> Get()
        {
            List<Task> taskList = new List<Task>();
            try // tentar/tentativa
            {
                taskList = _taskService.GetAll();
            }
            catch (Exception e) // pegar o erro
            {
                return NotFound();
            }
            if(taskList.Count == 0)
            {
                return NotFound();
            }
            return taskList;
        }

        [HttpPost]
        [ProducesResponseType(typeof(Task), StatusCodes.Status200OK)]
        public ActionResult<Task> Post(Task task)
        {
            try
            {
                return _taskService.SaveTask(task);
            }
            catch(Exception e)
            {
                return BadRequest(e);
            }

        }

        [HttpPost("{id}")]
        [ProducesResponseType(typeof(Task), StatusCodes.Status200OK)]
        public ActionResult<Task> Post(int id, Task task)
        {
            try
            {
                return _taskService.UpdateTask(id, task);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }

        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(Task), StatusCodes.Status200OK)]
        public ActionResult<int> Delete(int id)
        {
            try
            {
                return _taskService.DeleteTask(id);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }

        }
    }
}
