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
    public class BoardController : ControllerBase
    {
        private readonly IBoardService _service;
        private readonly ILogger<BoardController> _logger;

        public BoardController(IBoardService service, ILogger<BoardController> logger)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(typeof(Board), StatusCodes.Status200OK)]
        public ActionResult<List<Board>> Get()
        {
            List<Board> list = new List<Board>();
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
        [ProducesResponseType(typeof(Board), StatusCodes.Status200OK)]
        public ActionResult<BoardResponse> Get(int id)
        {
            BoardResponse board;
            try // tentar/tentativa
            {
                board = _service.GetById(id);
            }
            catch (Exception e) // pegar o erro
            {
                return NotFound();
            }

            return board;
        }

        [HttpPost]
        [ProducesResponseType(typeof(Board), StatusCodes.Status200OK)]
        public ActionResult<Board> Post(Board board)
        {
            try
            {
                return _service.SaveBoard(board);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }

        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(Board), StatusCodes.Status200OK)]
        public ActionResult<int> Delete(int id)
        {
            try
            {
                return _service.DeleteBoard(id);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }

        }
    }
}