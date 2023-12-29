using Microsoft.AspNetCore.Mvc;
using PresenceControl.Models;
using System.Diagnostics;

namespace PresenceControl.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        private readonly YourDbContext _dbContext;

        public HomeController(YourDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public async Task<List<Employee>> GetEmployees()
        {
            throw new NotImplementedException();
        }


        [HttpGet("api/employee/{id}")]
        public async Task<Employee> GetEmployee(int id)
        {
            throw new NotImplementedException();
        }
        
        [HttpGet("api/Salaries")]

        public async Task<Salary> GetSalaries()
        {
            // Puedes realizar operaciones con _dbContext aquí
            throw new NotImplementedException();

        }
        [HttpGet("api/Presences")]

        public async Task<Presence> GetPresences()
        {
            throw new NotImplementedException();

        }
        /*
         *  [HttpGet("api/employee")]
        public IActionResult GetEmployee()
        {
            // Puedes realizar operaciones con _dbContext aquí
            var model = _dbContext.Employees.ToList();

            return View(model);
        }
        [HttpGet("api/Salaries")]

        public IActionResult GetSalaries()
        {
            // Puedes realizar operaciones con _dbContext aquí
            var model2 = _dbContext.Salaries.ToList();

            return View(model2);
        }
        [HttpGet("api/Presences")]

        public IActionResult GetPresences()
        {
            // Puedes realizar operaciones con _dbContext aquí
            var model3 = _dbContext.Presences.ToList();

            return View(model3);
        }
         */

    }
}
