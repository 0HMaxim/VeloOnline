using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeloOnline.Models;
using VeloOnline.Models.ViewModels;

namespace bikeOnline.Controllers
{
    [Authorize (Roles="admin")]
    public class AdminController : Controller
    {
        BikeContext context;
        public AdminController(BikeContext context)
        {
            this.context = context;
        }
        public IActionResult Index(int id)
        {
            ViewBag.countPage = Math.Round(context.Bicycles.ToList().Count / 10.0, MidpointRounding.ToPositiveInfinity);


            return View(context.Bicycles.ToList()
                                        .Skip((id - 1) * 10)
                                        .Take(10)
                                        .ToList());
        }
        [HttpGet]
        public IActionResult Create(int? id, string returnUrl)
        {
            if (id == null)
            {
                return View(new EditBikeViewModel { ReturnUrl = returnUrl });
            }
            else
            {
                var bikeToEdit = context.Bicycles.Find(id);
                return View(new EditBikeViewModel { Bike = bikeToEdit, ReturnUrl = returnUrl });
            }
        }
        [HttpPost]
        public IActionResult Create(EditBikeViewModel model)
        {
     
            if (ModelState.IsValid)
            {
                if (model.Bike.BikeId == null)
                    context.Bicycles.Add(model.Bike);
                else
                {
                    var bikeToEdit = context.Bicycles.Find(model.Bike.BikeId);
                    bikeToEdit.Title = model.Bike.Title;
                    bikeToEdit.Manufacturer = model.Bike.Manufacturer;
                    bikeToEdit.ImageUrl = model.Bike.ImageUrl;
                    bikeToEdit.WheelSize = model.Bike.WheelSize;
                    bikeToEdit.Price = model.Bike.Price;
                    bikeToEdit.NumberOfSpeeds = model.Bike.NumberOfSpeeds;
                    bikeToEdit.Weight = model.Bike.Weight;
                    bikeToEdit.ImageUrl = model.Bike.ImageUrl;

                    context.Update(bikeToEdit);

                }
                context.SaveChanges();

            }
            else
                return View(model);

            return Redirect("Index");
        }

        [HttpPost]
        public IActionResult Delete(int bikeId, string returnUrl)
        {
            var bikeToDelete = context.Bicycles.Find(bikeId);
            context.Bicycles.Remove(bikeToDelete);
            context.SaveChanges();
            return Redirect(returnUrl);
        }
    }
}
