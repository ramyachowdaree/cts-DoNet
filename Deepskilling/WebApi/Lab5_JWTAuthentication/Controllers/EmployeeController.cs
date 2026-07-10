using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Lab5_JWTAuthentication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    [Authorize(Roles = "Admin")]

    public class EmployeeController : ControllerBase
    {
        static List<Employee> employees = new List<Employee>()
        {
            new Employee
            {
                Id=101,
                Name="Ramya",
                Department="AIML",
                Salary=50000
            },

            new Employee
            {
                Id=102,
                Name="Rahul",
                Department="CSE",
                Salary=60000
            }
        };

        [HttpGet]
        public IActionResult GetEmployees()
        {
            return Ok(employees);
        }
    }
}