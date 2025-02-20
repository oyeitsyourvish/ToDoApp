using Microsoft.AspNetCore.Mvc;

namespace ToDoPortal.Controllers
{
    public class ToDoController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
