using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaNet_ValeriaPiedrahita.DTO.GuestDTO
{
    public class GuestDTO
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required string IdentificationNumber { get; set; }
        public required string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
    }
}