using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaNet_ValeriaPiedrahita.DTO.BookingDTO;
using PruebaNet_ValeriaPiedrahita.Models;
using PruebaNet_ValeriaPiedrahita.Repositories;

namespace PruebaNet_ValeriaPiedrahita.Controllers.v1.Bookings
{
    [ApiController]
    [Route("api/v1/bokkings")]
    [Tags("bokkings")]
    public class BookingPostController : BookingsController
    {
        public BookingPostController(IBookingRepository bookingRepository) : base(bookingRepository)
        {
        }


        [HttpPost]
        public async Task<ActionResult<Booking>> Post([FromBody] BookingDTO guest)
        {
            await _bookingRepository.Add(guest);
            return Ok();
        }
    }
}