namespace TodoApi.Models
{
    public class TodoItem
    {
        // identifier for each todo item
        public long Id { get; set; }
        // description / name of item
        public string? Name { get; set; }
        // flags if item is completed or not
        public bool IsComplete { get; set; }
        // tracks the date a task was finished, can't be null
        public DateTime? CompletionDate { get; set; }
    }
}
