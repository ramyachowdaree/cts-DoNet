using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Lab4_CRUD_Operations.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>()
        {
            new Employee
            {
                Id = 101,
                Name = "Ramya",
                Department = "AIML",
                Salary = 50000
            },

            new Employee
            {
                Id = 102,
                Name = "Rahul",
                Department = "CSE",
                Salary = 60000
            }
        };

        [HttpGet]
        public ActionResult<List<Employee>> Get()
        {
            return employees;
        }

        [HttpPost]
        public IActionResult AddEmployee([FromBody] Employee emp)
        {
            employees.Add(emp);

            return Ok("Employee Added Successfully");
        }

        [HttpPut("{id}")]
        public ActionResult<Employee> UpdateEmployee(int id, [FromBody] Employee emp)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid employee id");
            }

            Employee employee = employees.FirstOrDefault(e => e.Id == id);

            if (employee == null)
            {
                return BadRequest("Invalid employee id");
            }

            employee.Name = emp.Name;
            employee.Department = emp.Department;
            employee.Salary = emp.Salary;

            return employee;
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            Employee employee = employees.FirstOrDefault(e => e.Id == id);

            if (employee == null)
            {
                return BadRequest("Invalid employee id");
            }

            employees.Remove(employee);

            return Ok("Employee Deleted Successfully");
        }
    }
}