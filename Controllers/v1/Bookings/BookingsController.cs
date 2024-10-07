using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaNet_ValeriaPiedrahita.Repositories;

namespace PruebaNet_ValeriaPiedrahita.Controllers.v1.Bookings
{
    [ApiController]
    [Route("api/v1/bookings")]
    public class BookingsController : ControllerBase
    {
         protected readonly IBookingRepository _bookingRepository;
         public BookingsController(IBookingRepository bookingRepository)
         {
             _bookingRepository = bookingRepository;
         }
        
    }
}