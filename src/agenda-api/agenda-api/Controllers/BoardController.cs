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
    public class BoardController : ControllerBase
    {
        private readonly ITaskService _service;
        private readonly ILogger<BoardController> _logger;

        public BoardController(ITaskService service, ILogger<BoardController> logger)
        {
            _service = service;
            _logger = logger;
        }
    }

    [HttpGet]
    [ProducesResponseType(typeof(Task), StatusCodes.Status200OK)]
    public ActionResult<List<Task>> Get()
    {
        List<Task> taskList = new List<Task>();
        try // tentar/tentativa
        {
            taskList = _service.GetAll();
        }
        catch (Exception e) // pegar o erro
        {
            return NotFound();
        }
        if (taskList.Count == 0)
        {
            return NotFound();
        }
        return taskList;
    }

    [HttpGet("{id}")]
    [ProducesResponseType(typeof(Task), StatusCodes.Status200OK)]
    public ActionResult<Task> Get(int id)
    {
        Task task;
        try // tentar/tentativa
        {
            task = _service.GetById(id);
        }
        catch (Exception e) // pegar o erro
        {
            return NotFound();
        }

        return task;
    }

    [HttpPost]
    [ProducesResponseType(typeof(Task), StatusCodes.Status200OK)]
    public ActionResult<Task> Post(Task task)
    {
        try
        {
            return _service.SaveTask(task);
        }
        catch (Exception e)
        {
            return BadRequest(e);
        }

    }
}
