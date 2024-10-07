using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaNet_ValeriaPiedrahita.Models
{
    //data anotation is used for the creation of tables and relationships
    [Table("room_types")]
    public class RoomType
    {
        [Key] //key for the primary key which is the id
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }
        //each attribute is told what is required and its character limit
        [Column("name")]
        [Required]
        [MaxLength(50)]
        public required string Name { get; set; }
        [Column("description")]
        [MaxLength(255)]
        public string Description { get; set; }

        //
        public ICollection<Room> Rooms { get; set; }
    }
}