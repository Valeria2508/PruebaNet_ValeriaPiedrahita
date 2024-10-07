using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaNet_ValeriaPiedrahita.Models
{
    [Table("bookings")]
    public class Booking
    {
        [Key] //key for the primary key which is the id
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("start_date")]
        public required DateTime StartDate { get; set; }

        [Column("end_date")]
        public DateTime EndDate { get; set; }

        [Required]
        [Column("total_cost")]
        public required double TotalCost { get; set; }


        //here are the foreign ones that are related to other classes
        [ForeignKey("room_id")]
        public required int RoomId  { get; set; }
        public Room Rooms {get; set;}

        [ForeignKey("guest_id")]
        public required int GuestId { get; set; }
        public Guest Guests { get; set; }

        [ForeignKey("employee_id")]
        public required int EmployeeId { get; set; }
        public Employee Employees { get; set; }

    }
}