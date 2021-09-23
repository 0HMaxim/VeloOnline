using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VeloOnline.Models
{
    public class Order
    {
        public int? OrderId { get; set; }
        [Required(ErrorMessage = "Firstname is required")]
        public string Firstname { get; set; }
        [Required(ErrorMessage = "Lastname is required")]
        public string Lastname { get; set; }
        [Required(ErrorMessage = "Phone is required")]
        [Phone(ErrorMessage = "Phone is not valid")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Email field is not a valid e-mail address")]
        public string Email { get; set; }
        public int? BikeId { get; set; }
        public Bike Bike { get; set; }
    }
}
