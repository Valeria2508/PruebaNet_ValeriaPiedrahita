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
    public class GuestPutController : GuestController
    {
        public GuestPutController(IGuestRepository guestRepository) : base(guestRepository)
        {
        }

        [HttpPut]
        public async Task<ActionResult<Guest>> Update([FromHeader]int id, [FromBody] GuestDTO user){
            await _guestRepository.Update(id, user);
            return Ok();
        }
    }
}