using Microsoft.AspNetCore.Mvc;

namespace Systemutviklerskolen_todo_app_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodoController : ControllerBase
    {
        [HttpGet]
        public ActionResult Index()
        {

        }

        [HttpPost]
        public ActionResult PostTodo(Todo input)
        {

        }

        [HttpPut]
        public ActionResult UpdateTodo(Todo input)
        {

        }
    }
}