using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PruebaNet_ValeriaPiedrahita.Data;
using PruebaNet_ValeriaPiedrahita.DTO.RoomTypeDTO;
using PruebaNet_ValeriaPiedrahita.Models;
using PruebaNet_ValeriaPiedrahita.Repositories;

namespace PruebaNet_ValeriaPiedrahita.Services
{
    public class RoomTypeService : IRoomTypeRepository
    {
        protected readonly ApplicationDbContext _context;

        public RoomTypeService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<RoomTypeDTO>> GetAll()
        {
            var category = await _context.RoomTypes.Select(category => new RoomTypeDTO
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description,
            }).ToListAsync();
            return category;
        }


        public async Task<RoomTypeDTO> GetById(int id)
        {
            var category = await _context.RoomTypes.Where(r => r.Id == id).Select(c => new RoomTypeDTO
            {
                Id = c.Id,
                Name = c.Name,
                Description = c.Description
            }).FirstOrDefaultAsync();
            return category;
        }

     
    }
}