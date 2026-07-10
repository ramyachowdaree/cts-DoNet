using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Lab3_CustomModel_Filter.Filters;

namespace Lab3_CustomModel_Filter.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [CustomAuthFilter]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>()
        {
            new Employee
            {
                Id=101,
                Name="Ramya",
                Salary=50000,
                Permanent=true,
                Department=new Department{Id=1,Name="AIML"},
                Skills=new List<Skill>
                {
                    new Skill{Id=1,Name="C#"},
                    new Skill{Id=2,Name="SQL"}
                },
                DateOfBirth=new System.DateTime(2003,5,10)
            }
        };

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
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
    }
}