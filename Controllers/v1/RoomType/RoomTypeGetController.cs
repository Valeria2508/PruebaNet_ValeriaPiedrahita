using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaNet_ValeriaPiedrahita.Repositories;

namespace PruebaNet_ValeriaPiedrahita.Controllers.v1
{
    [ApiController]
    [Route("api/v1/room_types")]
    [Tags("room_types")]
    public class RoomTypeGetController : RoomTypeController
    {
        public RoomTypeGetController(IRoomTypeRepository roomTypeRepository) : base(roomTypeRepository)
        {
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Models.RoomType>>> Get()
        {
            var roomTypes = await _roomTypeRepository.GetAll();
            return Ok(roomTypes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Models.RoomType>> GetById(int id)
        {
            var roomType = await _roomTypeRepository.GetById(id);
            if (roomType == null)
            {
                return NotFound();
            }
            return Ok(roomType);
        }
    }
}