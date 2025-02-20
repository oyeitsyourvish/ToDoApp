using Microsoft.EntityFrameworkCore;
using ToDoPortal.Models.Entities;

namespace ToDoPortal.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<ToDo> ToDos { get; set; }
    }
}
