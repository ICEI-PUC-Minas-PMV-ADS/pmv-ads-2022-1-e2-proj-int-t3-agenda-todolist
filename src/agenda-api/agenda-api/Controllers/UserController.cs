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
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;
        private readonly ITaskService _taskService;
        private readonly ILogger<UserController> _logger;

        public UserController(IUserService service, ITaskService taskService, ILogger<UserController> logger)
        {
            _service = service;
            _taskService = taskService;
            _logger = logger;
        }


        [HttpGet]
        [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
        public ActionResult<List<User>> Get()
        {
            List<User> list = new List<User>();
            try // tentar/tentativa
            {
                list = _service.GetAll();
            }
            catch (Exception e) // pegar o erro
            {
                return NotFound();
            }

            return list;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
        public ActionResult<User> Get(int id)
        {
            User user;
            try // tentar/tentativa
            {
                user = _service.GetById(id);
            }
            catch (Exception e) // pegar o erro
            {
                return NotFound();
            }

            return user;
        }

        [HttpPost("login")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult Login(UserRequest user)
        {
            try
            {
                if(_service.Login(user))
                {
                    return Ok();
                }
                else
                {
                    return BadRequest("usuário ou senha invalidos");
                }
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpPost]
        [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
        public ActionResult<User> Post(User user)
        {
            try
            {
                return _service.SaveUser(user);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }

        }

        [HttpPost("{id}")]
        [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
        public ActionResult<User> Post(int id, User user)
        {
            try
            {
                return _service.UpdateUser(id, user);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }

        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
        public ActionResult<int> Delete(int id)
        {
            try
            {
                return _service.DeleteUser(id);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }

        }

        [HttpGet("{id}/tasks")]
        [ProducesResponseType(typeof(Task), StatusCodes.Status200OK)]
        public ActionResult<List<TaskReponse>> GetTasks(int id)
        {
            List<TaskReponse> tasks = new List<TaskReponse>();
            try // tentar/tentativa
            {
                tasks = _taskService.GetAllTasksByUser(id);
            }
            catch (Exception e) // pegar o erro
            {
                return NotFound();
            }

            return tasks;
        }

    }
}
