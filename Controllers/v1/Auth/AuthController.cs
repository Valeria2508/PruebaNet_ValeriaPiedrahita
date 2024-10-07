using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaNet_ValeriaPiedrahita.DTO.Auth;
using PruebaNet_ValeriaPiedrahita.Repositories;

namespace PruebaNet_ValeriaPiedrahita.Controllers.v1.Auth
{
    [ApiController]
    [Route("api/v1/auth")]
    public class AuthController : ControllerBase
    {
        protected readonly IEmployeerepository _employeeRepository;
        
        public AuthController(IEmployeerepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<string>> login( LoginDTO login)
        {
            var token = await _employeeRepository.Login(login);
            return Ok($"Logged in successfully this is your token: {token}");
        }
        
    }
}