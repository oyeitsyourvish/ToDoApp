namespace ToDoPortal.Models.Entities
{
    public class ToDo
    {
        public int Id { get; set; }
        public string? Title { get; set; } // this is my primary key
        public string? Description { get; set; }
        public DateOnly? Date { get; set; }
        public bool? isImportant { get; set; }
    }
}
