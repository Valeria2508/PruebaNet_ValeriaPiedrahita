using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PruebaNet_ValeriaPiedrahita.DTO.GuestDTO;
using PruebaNet_ValeriaPiedrahita.Models;
using PruebaNet_ValeriaPiedrahita.Repositories;

namespace PruebaNet_ValeriaPiedrahita.Controllers.v1.Guests
{
    [ApiController]
    [Route("api/v1/guests")]
    [Tags("guest")]
    public class GuestGetController : GuestController
    {
        public GuestGetController(IGuestRepository guestRepository) : base(guestRepository)
        {
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<List<Guest>>> GetGuests()
        {
            var guests = await _guestRepository.GetAll();
            return Ok(guests);
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<Guest>> GetGuestById(int id)
        {
            var guest = await _guestRepository.GetById(id);
            if (guest == null)
            {
                return NotFound();
            }
            return Ok(guest);
        }

        [HttpGet("search")]
        [Authorize]
        public async Task<ActionResult<IEnumerable<GuestDTO>>> GetByKeyword([FromQuery] string keyword)
        {
            return Ok(await _guestRepository.GetByKeyword(keyword));
        }
    }
}