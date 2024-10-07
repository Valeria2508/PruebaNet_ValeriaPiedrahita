using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaNet_ValeriaPiedrahita.DTO.GuestDTO;
using PruebaNet_ValeriaPiedrahita.Models;
using PruebaNet_ValeriaPiedrahita.Repositories;

namespace PruebaNet_ValeriaPiedrahita.Controllers.v1.Guests
{
    [ApiController]
    [Route("api/v1/guest")]
    [Tags("guest")]
    public class GuestPostController : GuestController
    {
        public GuestPostController(IGuestRepository guestRepository) : base(guestRepository)
        {
        }

        [HttpPost]
        public async Task<ActionResult<Guest>> Post([FromBody] GuestDTO guest)
        {
            await _guestRepository.Add(guest);
            return Ok();
        }
    }
}