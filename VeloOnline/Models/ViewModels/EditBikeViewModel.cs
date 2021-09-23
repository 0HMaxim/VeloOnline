using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeloOnline.Models.ViewModels
{
    public class EditBikeViewModel
    {
        public Bike Bike { get; set; }
        public string ReturnUrl { get; set; }
    }
}
