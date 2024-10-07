using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaNet_ValeriaPiedrahita.Repositories;

namespace PruebaNet_ValeriaPiedrahita.Controllers.v1.Room
{
    [ApiController]
    [Route("api/v1/rooms")]
    [Tags("rooms")]
    public class RoomGetController : RoomController
    {
        public RoomGetController(IRoomRepository roomRepository) : base(roomRepository)
        {
        }

        [HttpGet]
        [Route("available")]
        public async Task<IActionResult> GetAvailableRooms()
        {
            var rooms = await _roomRepository.GetAvailable();
            return Ok(rooms);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Models.Room>> GetById(int id)
        {
            var room = await _roomRepository.GetById(id);
            if (room == null)
            {
                return NotFound();
            }
            return Ok(room);
        }

        [HttpGet]
        public async Task<ActionResult> GetAllRooms(){
            var rooms = await _roomRepository.GetAll();
            return Ok(rooms);
        }

        [HttpGet]
        [Route("status")]
        public async Task<IActionResult> GetStatus()
        {
            var rooms = await _roomRepository.GetStatus();
            return Ok(rooms);
        }

        [HttpGet]
        [Route("ocuppied")]
        public async Task<IActionResult> GetOcuppiedRooms()
        {
            var rooms = await _roomRepository.GetOccupied();
            return Ok(rooms);
        }


    }
}