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
        public IEnumerable<Task> Get()
        {
            List<Task> taskList = new List<Task>();
            try
            {
                taskList = _taskService.GetAll();
            }
            catch (Exception e)
            {
            }

            return taskList;
        }

        [HttpPost]
        public HttpResponseMessage Post(Task task)
        {
            try
            {
                _taskService.SaveTask(task);
            }
            catch(Exception e)
            {
                HttpResponseMessage response2 = new HttpResponseMessage(HttpStatusCode.BadRequest);
                response2.Content = new StringContent(e.Message, Encoding.Unicode);
                return response2;
            }

            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);
            response.Content = new StringContent("hello", Encoding.Unicode);

            return response;
        }
    }
}
