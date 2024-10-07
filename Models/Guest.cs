using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaNet_ValeriaPiedrahita.Models
{
    [Table("guests")]
    public class Guest
    {
        [Key] //key for the primary key which is the id
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id {get; set;}

        [Column("first_name")]
        [Required]
        [MaxLength(255)]
        public required string FirstName {get; set;}

        [Column("last_name")]
        [Required]
        [MaxLength(255)]
        public required string LastName {get; set;}

        [Column("email")]
        [Required]
        [MaxLength(255)]
        [EmailAddress]
        public required string Email {get; set;}

        [Column("identification_number")]
        [Required]
        [MaxLength(20)]
        public required string IdentificationNumber {get; set;}

        [Column("phone_number")]
        [Required]
        [MaxLength(20)]
        [Phone]
        public required string PhoneNumber {get; set;}

        [Column("birthDate")]
        public DateTime BirthDate {get; set;}

        public ICollection<Booking> Bookings {get; set;}
    }
}