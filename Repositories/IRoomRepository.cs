using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaNet_ValeriaPiedrahita.DTO.RoomDTO;
using PruebaNet_ValeriaPiedrahita.Models;

namespace PruebaNet_ValeriaPiedrahita.Repositories
{
    public interface IRoomRepository
    {
        Task<IEnumerable<RoomDTO>> GetAll();
        Task<RoomDTO> GetById(int id);
        Task<IEnumerable<RoomDTO>> GetAvailable();
        Task<IEnumerable<RoomDTO>> GetOccupied();
        Task<IEnumerable<RoomStatusDTO>> GetStatus();

    }
}