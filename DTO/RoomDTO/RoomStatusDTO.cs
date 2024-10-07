using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaNet_ValeriaPiedrahita.DTO.RoomDTO
{
    public class RoomStatusDTO
    {
        public int Id { get; set; }
        public required string RoomNumber { get; set; }
        public required double PricePerNight { get; set; }
        public required bool Availability { get; set; }
    }
}