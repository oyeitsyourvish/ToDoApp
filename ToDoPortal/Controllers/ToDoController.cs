using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDoPortal.Data;
using ToDoPortal.Models;
using ToDoPortal.Models.Entities;

namespace ToDoPortal.Controllers
{
    public class ToDoController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public ToDoController(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(ToDoViewModel viewModel)
        {
            var todo = new ToDo
            {
                Title = viewModel.Title,
                Description = viewModel.Description,
                Date = viewModel.Date,
                isImportant = viewModel.isImportant
            };
            await _dbContext.ToDos.AddAsync(todo);
            await _dbContext.SaveChangesAsync();


            return View();
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var noteList = await _dbContext.ToDos.ToListAsync();
            return View(noteList);
        }
    }
}
