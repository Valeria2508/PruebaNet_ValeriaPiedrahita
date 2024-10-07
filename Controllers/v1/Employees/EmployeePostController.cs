using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaNet_ValeriaPiedrahita.DTO.EmployeeDTO;
using PruebaNet_ValeriaPiedrahita.Models;
using PruebaNet_ValeriaPiedrahita.Repositories;

namespace PruebaNet_ValeriaPiedrahita.Controllers.v1.Employees
{
    [ApiController]
    [Route("api/v1/employees")]
    [Tags("employees")]
    public class EmployeePostController : EmployeeController
    {
        public EmployeePostController(IEmployeerepository employeeRepository) : base(employeeRepository)
        {
        }

        [HttpPost]
        public async Task<ActionResult<Employee>> Post([FromBody] EmployeeDTO user)
        {
            await _employeeRepository.Add(user);
            return Ok();
        }
    }
}