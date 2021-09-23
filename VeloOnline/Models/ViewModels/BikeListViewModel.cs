using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeloOnline.Models.ViewModels
{
    public class BikeListViewModel
    {
        public List<Bike> Bikes { get; set; }
        public List<string> Manufacturer { get; set; }
        public List<string> SelectedManufacturer { get; set; }
        public double  MinWheelSize { get; set; }
        public double  MaxWheelSize { get; set; }
        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }
        public int MinNumberOfSpeeds { get; set; }
        public int MaxNumberOfSpeeds { get; set; }
        public double MinWeight { get; set; }
        public double MaxWeight { get; set; }
    }
}
