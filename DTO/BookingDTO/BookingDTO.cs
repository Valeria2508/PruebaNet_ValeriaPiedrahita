using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaNet_ValeriaPiedrahita.DTO.BookingDTO
{
    public class BookingDTO
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double TotalCost { get; set; }
        public int RoomId { get; set; }
        public int GuestId { get; set; }
        public int EmployeeId { get; set; }
        public RoomDTO.RoomDTO Room { get; internal set; }
        public string EmployeeIdName { get; internal set; }
        public string GuestIdName { get; internal set; }
        public string RoomIdName { get; internal set; }
        public double RoomIdCost { get; internal set; }
    }
}