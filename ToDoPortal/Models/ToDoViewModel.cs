namespace ToDoPortal.Models
{
    public class ToDoViewModel
    {
        public string? Title { get; set; } // this is my primary key
        public string? Description { get; set; }
        public DateOnly? Date { get; set; }
        public bool? isImportant { get; set; } = false;
    }
}
