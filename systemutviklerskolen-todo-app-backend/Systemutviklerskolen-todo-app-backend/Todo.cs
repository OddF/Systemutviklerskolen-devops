namespace Systemutviklerskolen_todo_app_backend
{
    public class Todo
    {
        public Guid Id { get; set; }

        public DateTime Done { get; set; }

        public string? Task { get; set; }
    }
}