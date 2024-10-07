using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaNet_ValeriaPiedrahita.Repositories;

namespace PruebaNet_ValeriaPiedrahita.Controllers.v1.Employees
{
    [ApiController]
    [Route("api/v1/employees")]
    public class EmployeeController : ControllerBase
    {
        protected readonly IEmployeerepository _employeeRepository;

        public EmployeeController(IEmployeerepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
    }
}