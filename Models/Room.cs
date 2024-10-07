using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaNet_ValeriaPiedrahita.Models
{
    [Table("rooms")]
    public class Room
    {
        [Key] //key for the primary key which is the id
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public required int Id { get; set; }

        [Column("room_number")]
        [Required]
        [MaxLength(10)]
        public required string RoomNumber { get; set; }

        [Column("price_per_night")]
        [Required]
        public required double PricePerNight {get; set;}

        [Column("availability")]
        [Required]
        public required bool Availability {get; set; }

        [Column("max_occuppancy_person")]
        [Required]
        public required int MaxOccuppancyPerson {get; set; }

        //relation with RoomType one to many
        [ForeignKey("room_type_id")]
        public int RoomTypeId {get;set;}
        public RoomType RoomTypes { get; set; }     
    }
}