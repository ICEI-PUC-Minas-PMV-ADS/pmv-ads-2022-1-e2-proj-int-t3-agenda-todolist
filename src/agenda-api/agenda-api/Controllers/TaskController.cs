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
using Microsoft.AspNetCore.Cors;

namespace agenda_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [EnableCors("Policy1")]
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
        [ProducesResponseType(typeof(TaskReponse), StatusCodes.Status200OK)]
        public ActionResult<List<TaskReponse>> Get()
        {
            List<TaskReponse> taskList;
            try // tentar/tentativa
            {
                taskList = _taskService.GetAll();
            }
            catch (Exception e) // pegar o erro
            {
                return NotFound();
            }

            return taskList;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(TaskReponse), StatusCodes.Status200OK)]
        public ActionResult<TaskReponse> Get(int id)
        {
            TaskReponse task;
            try // tentar/tentativa
            {
                task = _taskService.GetById(id);
            }
            catch (Exception e) // pegar o erro
            {
                return NotFound();
            }

            return task;
        }

        [HttpPost]
        [ProducesResponseType(typeof(TaskReponse), StatusCodes.Status200OK)]
        public ActionResult<TaskReponse> Post(TaskRequest task)
        {
            try
            {
                return _taskService.SaveTask((Task)task);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        [HttpPost("{id}")]
        [ProducesResponseType(typeof(TaskReponse), StatusCodes.Status200OK)]
        public ActionResult<TaskRequest> Post(int id, TaskRequest task)
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
        [ProducesResponseType(typeof(TaskReponse), StatusCodes.Status200OK)]
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
