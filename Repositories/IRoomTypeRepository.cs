using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaNet_ValeriaPiedrahita.DTO.RoomTypeDTO;
using PruebaNet_ValeriaPiedrahita.Models;

namespace PruebaNet_ValeriaPiedrahita.Repositories
{
    public interface IRoomTypeRepository
    {
        Task<IEnumerable<RoomTypeDTO>> GetAll();
        Task<RoomTypeDTO> GetById(int id);
    }
}