using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PruebaNet_ValeriaPiedrahita.Data;
using PruebaNet_ValeriaPiedrahita.DTO.BookingDTO;
using PruebaNet_ValeriaPiedrahita.Models;
using PruebaNet_ValeriaPiedrahita.Repositories;

namespace PruebaNet_ValeriaPiedrahita.Services
{
    public class BookingService : IBookingRepository
    {
        protected readonly ApplicationDbContext _context;
        public BookingService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task Add(BookingDTO bookingDTO)
        {
            var booking = new Booking
            {
                Id = bookingDTO.Id,
                StartDate = bookingDTO.StartDate,
                EndDate = bookingDTO.EndDate,
                TotalCost = bookingDTO.TotalCost,
                RoomId = bookingDTO.RoomId,
                GuestId = bookingDTO.GuestId,
                EmployeeId = bookingDTO.EmployeeId,
            };
            _context.Bookings.Add(booking);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var booking = await _context.Bookings.FindAsync(id);
            if (booking != null)
            {
                _context.Bookings.Remove(booking);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<BookingDTO> GetById(int id)
        {
            var booking = await _context.Bookings.Include(b => b.Rooms).Include(b => b.Guests).Include(b => b.Employees).Where(b => b.Id == id).Select(b => new BookingDTO
            {
                Id = b.Id,
                StartDate = b.StartDate,
                EndDate = b.EndDate,
                TotalCost = b.TotalCost,
                RoomId = b.RoomId,
                GuestId = b.GuestId,
                EmployeeId = b.EmployeeId,
                EmployeeIdName = b.Employees.FirstName,
                GuestIdName = b.Guests.FirstName,
                RoomIdName = b.Rooms.RoomNumber,
                RoomIdCost = b.Rooms.PricePerNight 
            }).FirstOrDefaultAsync();
            return booking;
        }

        public Task<BookingDTO> GetByIdentificationNumber(string identificationNumber)
        {
            throw new NotImplementedException();
        }
    }
}