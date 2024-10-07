using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaNet_ValeriaPiedrahita.DTO.BookingDTO;

namespace PruebaNet_ValeriaPiedrahita.Repositories
{
    public interface IBookingRepository
    {
        Task<BookingDTO> GetById(int id);
        Task<BookingDTO> GetByIdentificationNumber(string identificationNumber);
        Task Delete(int id);
        Task Add(BookingDTO bookingDTO);

    }
}