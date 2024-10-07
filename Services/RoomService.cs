using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PruebaNet_ValeriaPiedrahita.Data;
using PruebaNet_ValeriaPiedrahita.DTO.RoomDTO;
using PruebaNet_ValeriaPiedrahita.DTO.RoomTypeDTO;
using PruebaNet_ValeriaPiedrahita.Repositories;

namespace PruebaNet_ValeriaPiedrahita.Services
{
    public class RoomService : IRoomRepository
    {
        protected readonly ApplicationDbContext _context;
        public RoomService(ApplicationDbContext context)
        {
            _context = context;
        }



        public async Task<IEnumerable<RoomDTO>> GetAll()    
        {
            var room = await _context.Rooms.Include(room => room.RoomTypes).Select(room => new RoomDTO{
                Id = room.Id,
                RoomNumber = room.RoomNumber,
                PricePerNight = room.PricePerNight,
                Availability = room.Availability,
                MaxOccupancyPerson = room.MaxOccuppancyPerson,
                RoomTypeId = room.RoomTypeId,
                RoomTypeName = room.RoomTypes.Name,
            }).ToArrayAsync();
            return room;
        }

        public async Task<IEnumerable<RoomDTO>> GetAvailable()
        {
            var room = await _context.Rooms.Include(room => room.RoomTypes).Where(room => room.Availability == true ).Select(room => new RoomDTO{
                Id = room.Id,
                RoomNumber = room.RoomNumber,
                PricePerNight = room.PricePerNight,
                Availability = room.Availability,
                MaxOccupancyPerson = room.MaxOccuppancyPerson,
                RoomTypeId = room.RoomTypeId,
                RoomTypeName = room.RoomTypes.Name,
            }).ToArrayAsync();
            return room;
        }

        public async Task<RoomDTO> GetById(int id)
        {
            var room = await _context.Rooms.Include(room => room.RoomTypes).Where(room => room.Id == id ).Select(room => new RoomDTO{
                Id = room.Id,
                RoomNumber = room.RoomNumber,
                PricePerNight = room.PricePerNight,
                Availability = room.Availability,
                MaxOccupancyPerson = room.MaxOccuppancyPerson,
                RoomTypeId = room.RoomTypeId,
                RoomTypeName = room.RoomTypes.Name,
            }).ToArrayAsync();
            return room.FirstOrDefault();
        }

        public async Task<IEnumerable<RoomDTO>> GetOccupied()
        {
            var room = await _context.Rooms.Include(room => room.RoomTypes).Where(room => room.Availability == false ).Select(room => new RoomDTO{
                Id = room.Id,
                RoomNumber = room.RoomNumber,
                PricePerNight = room.PricePerNight,
                Availability = room.Availability,
                MaxOccupancyPerson = room.MaxOccuppancyPerson,
                RoomTypeId = room.RoomTypeId,
                RoomTypeName = room.RoomTypes.Name,
            }).ToArrayAsync();
            return room;
        }

        public async Task<IEnumerable<RoomStatusDTO>> GetStatus()
        {
            var room = await _context.Rooms.Select(room => new RoomStatusDTO{
                Id = room.Id,
                RoomNumber = room.RoomNumber,
                PricePerNight = room.PricePerNight,
                Availability = room.Availability,
            }).ToArrayAsync();
            return room;
        }
    }
}