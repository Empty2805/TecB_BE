using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WanoSoft_TecB.Models;
using Microsoft.Extensions.Logging;

namespace WanoSoft_TecB.Controllers
{
	[Route("[controller]")]
	[ApiController]
    public class EmployeeController :ControllerBase
    {
		[HttpGet]
		[Produces("application/json")]
        public IActionResult Get()
        {
            var employees = GetEmployeesDetail();
			return Ok(employees);
        }

		[HttpGet("{id}")]
		[Produces("application/json")]
		public Employee Get(int id)
        {
			return GetEmployeesDetail().Find(e => e.Id == id);
        }

		[HttpPost]
		[Produces("application/json")]
		public Employee Post([FromBody] Employee employee)
        {
			return new Employee()
			{
				Id = 4,
				FirstName = employee.FirstName,
				LastName = employee.LastName,
				EmailId = employee.EmailId
			};
        }

        private List<Employee> GetEmployeesDetail()
        {
			return new List<Employee>()
		{
			new Employee()
			{
				Id = 1,
				FirstName= "Test",
				LastName = "Name",
				EmailId ="Test.Name@gmail.com"
			},
			new Employee()
			{
				Id = 2,
				FirstName= "Test",
				LastName = "Name1",
				EmailId ="Test.Name1@gmail.com"
			}
		};
		}
    }
    
}
