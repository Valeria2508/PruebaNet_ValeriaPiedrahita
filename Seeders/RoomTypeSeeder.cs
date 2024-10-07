using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PruebaNet_ValeriaPiedrahita.Models;

namespace PruebaNet_ValeriaPiedrahita.Seeders
{
    public class RoomTypeSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RoomType>().HasData(
            new RoomType
                {
                    Id = 1,
                    Name = "single room",
                    Description = "a cozy basic room with a single bed, ideal for solo travelers.",
                },
            new RoomType
            {
                Id = 2,
                Name = "double room",
                Description = "offers flexibility with either two single beds or a double bed, perfect for couples or friends.",
            },
            new RoomType
            {
                Id = 3,
                Name = "suite",
                Description = "spacious and luxurious, with a king-size bed and a separate living area, ideal for those seeking comfort and exclusivity.",
            },
            new RoomType
            {
                Id = 4,
                Name = "family room",
                Description = "designed for families, with extra space and multiple beds for a comfortable stay.",
            }
            );
        }
    }
}