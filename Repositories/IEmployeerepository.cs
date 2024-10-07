using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaNet_ValeriaPiedrahita.DTO.Auth;
using PruebaNet_ValeriaPiedrahita.DTO.EmployeeDTO;

namespace PruebaNet_ValeriaPiedrahita.Repositories
{
    public interface IEmployeerepository
    {
        Task Add(EmployeeDTO product);
        Task<string> Login(LoginDTO login);
    
    }
}