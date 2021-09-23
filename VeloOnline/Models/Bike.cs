using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VeloOnline.Models
{
    public class Bike
    {
        public int? BikeId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Manufacturer { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        public string Description { get; set; }
        [Range(1,1000000)]
        public double WheelSize { get; set; }
        [Range(1,1000000)]
        public int NumberOfSpeeds { get; set; }
        [Range(1,1000000)]
        public double Weight { get; set; }
        [Range(1,1000000)]
        public decimal Price { get; set; }
    }
}
