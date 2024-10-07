using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaNet_ValeriaPiedrahita.Repositories;

namespace PruebaNet_ValeriaPiedrahita.Controllers.v1.Bookings
{
    [ApiController]
    [Route("api/v1/bokkings")]
    [Tags("booking")]
    public class BookingGetController : BookingsController
    {
        public BookingGetController(IBookingRepository bookingRepository) : base(bookingRepository)
        {
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Models.Booking>> Get(int id)
        {
            var booking = await _bookingRepository.GetById(id);
            if (booking == null)
            {
                return NotFound();
            }
            return Ok(booking);
        }
    }
}