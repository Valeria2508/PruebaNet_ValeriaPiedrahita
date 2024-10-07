using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PruebaNet_ValeriaPiedrahita.Config;
using PruebaNet_ValeriaPiedrahita.Data;
using PruebaNet_ValeriaPiedrahita.DTO.Auth;
using PruebaNet_ValeriaPiedrahita.DTO.EmployeeDTO;
using PruebaNet_ValeriaPiedrahita.Models;
using PruebaNet_ValeriaPiedrahita.Repositories;

namespace PruebaNet_ValeriaPiedrahita.Services
{
    public class EmployeeService : IEmployeerepository
    {
        protected readonly ApplicationDbContext _context;
        protected readonly Utilities _utilities;
        public EmployeeService(ApplicationDbContext context, Utilities utilities)
        {
            _context = context;
            _utilities = utilities;
        }
        public async Task Add(EmployeeDTO user)
        {
            user.Password = _utilities.EncryptSHA256(user.Password);
            var user1 = new Employee{
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                IdentificationNumber = user.IdentificationNumber,
                Password = user.Password, 
            };
            _context.Employees.Add(user1);
            await _context.SaveChangesAsync();
        }

        public async Task<string> Login(LoginDTO login)
        {
            var user1 = await _context.Employees.FirstOrDefaultAsync(u=> u.Email == login.Email);

            if (user1 != null)
            {
                if (user1.Password == _utilities.EncryptSHA256(login.Password)) //validate the password that is the same as the hashed password
                {
                        var token = _utilities.GenerateJwtToken(user1);
                        return token;
                }
                return "invalid user or password";
            }
            return "invalid user or password";
        }
    }
}