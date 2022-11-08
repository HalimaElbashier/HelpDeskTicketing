using HelpDeskTicketing.Data;
using Microsoft.AspNetCore.Mvc;

namespace HelpDeskTicketing.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly ApplicationDbContext _context;
        public EmployeesController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var Result = _context.Employees.ToList();   
            return View(Result);
        }
    }
}
