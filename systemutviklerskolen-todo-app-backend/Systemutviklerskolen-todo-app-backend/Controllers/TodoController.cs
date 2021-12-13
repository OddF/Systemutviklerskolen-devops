using Microsoft.AspNetCore.Mvc;
using Systemutviklerskolen_todo_app_backend.Services;

namespace Systemutviklerskolen_todo_app_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly TableService _tableService;
        public TodoController(TableService tableService)
        {
            _tableService = tableService;
        }
        [HttpGet]
        public ActionResult Index()
        {
            return new JsonResult(_tableService.GetAllRows());
        }

        [HttpPost]
        public ActionResult PostTodo(Todo input)
        {
            input.Id = input.Id != Guid.Empty ? input.Id : Guid.NewGuid();
            _tableService.AddOrUpdateEntity(input);
            return new JsonResult(_tableService.GetAllRows());
        }

        [HttpDelete]
        public ActionResult DeleteTodo(Todo input)
        {
            _tableService.DeleteEntity(input);
            return new JsonResult(_tableService.GetAllRows());
        }
    }
}