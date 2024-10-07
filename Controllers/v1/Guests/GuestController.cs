using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaNet_ValeriaPiedrahita.Repositories;

namespace PruebaNet_ValeriaPiedrahita.Controllers.v1.Guests
{
    [ApiController]
    [Route("api/v1/guests")]
    public class GuestController : ControllerBase
    {
        protected readonly IGuestRepository _guestRepository;
        
        public GuestController(IGuestRepository guestRepository)
        {
            _guestRepository = guestRepository;
        }
    }
}