using Core;
using Microsoft.AspNetCore.Mvc;
using Services.Todos;
using System.Collections.Generic;


namespace ApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private ITodoService _todoService;

        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        [HttpGet]
        public IEnumerable<Todo> Get()
        {
            return _todoService.GetAll();
        }
        
        [HttpGet("{id}")]
        public Todo Get(string id)
        {
            return _todoService.GetById(id);
        }

        [HttpPost]
        public IActionResult Add(Todo todo)
        {
            var temp = _todoService.Add(todo);
            return Ok(temp);
        }

        [HttpPatch]
        public IActionResult Update(Todo todo)
        {
            var temp = _todoService.Update(todo);
            return Ok(temp);
        }

        [HttpDelete]
        public IActionResult Delete(string id)
        {
            _todoService.Delete(id);
            return Ok( new { Message = "Eliminado correctamente"});
        }
    }
}