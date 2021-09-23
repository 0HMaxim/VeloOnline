using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Threading.Tasks;
using VeloOnline.Models;
using VeloOnline.Models.ViewModels;

namespace VeloOnline.Controllers
{
    public class HomeController : Controller
    {
        BikeContext context;
        public HomeController(BikeContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult Index(string mes)
        {

            ViewBag.Message = mes;


            return View();
        }

        public IActionResult BikeList(BikeListViewModel model, int id = 1, string sortType = "Title", string search = "")
        {
            List<Bike> bikes = context.Bicycles.ToList();

            if (!string.IsNullOrEmpty(search))
                bikes = bikes.Where(x => x.Title.ToLower().Contains(search.ToLower())).ToList();

            sortType = sortType.Replace('_', ' ');
            Type sort = new Bike().GetType();
            IList<PropertyInfo> props = new List<PropertyInfo>(sort.GetProperties());
            for (int i = 0; i < props.Count; i++)
                if (props[i].Name == sortType)
                    bikes.OrderBy(x => x.GetType().GetProperties()[0]).ToList();


            Type myModel = model.GetType();
            IList<PropertyInfo> propsModel = new List<PropertyInfo>(myModel.GetProperties());
            List<string> selectedManufacture = new List<string>();

            var val = propsModel[2].GetValue(model, null) as List<string>;
            if (val != null && val[0] != null)
            {
                selectedManufacture = new List<string>(val[0].Replace('_', ' ').Split(new string[] { "," }, StringSplitOptions.None));
                for (int j = 0; j < selectedManufacture.Count; j++)
                    selectedManufacture[j] = selectedManufacture[j].Replace('.', ',');
            }


            var wheelSize = bikes.Where(x => x.WheelSize >= model.MinWheelSize && x.WheelSize <= model.MaxWheelSize).ToList();
            var weight = bikes.Where(x => x.Weight >= model.MaxWeight && x.Weight <= model.MinWeight).ToList();
            var numberOfSpeeds = bikes.Where(x => x.NumberOfSpeeds >= model.MinNumberOfSpeeds && x.NumberOfSpeeds <= model.MaxNumberOfSpeeds).ToList();
            var price = bikes.Where(x => x.Price >= model.MinPrice && x.Price <= model.MaxPrice).ToList();
            var manufacturer = bikes.Where(x => selectedManufacture.Contains(x.Manufacturer)).ToList();


            var bicycles = wheelSize.Union(wheelSize)
                             .Union(weight)
                             .Union(numberOfSpeeds)
                             .Union(price)
                             .Union(manufacturer)
                             .ToList();

            if (bicycles.Count == 0)
                bicycles = bikes;



            ViewBag.countPage = Math.Round(bicycles.ToList().Count / 10.0, MidpointRounding.ToPositiveInfinity);
            ViewBag.id = id;
            return PartialView(new BikeListViewModel
            {
                Bikes = bicycles
                 .Skip((id - 1) * 10)
                 .Take(10)
                 .ToList(),


                MinPrice = model.MinPrice,
                MaxPrice = model.MaxPrice,
                MinWheelSize = model.MinWheelSize,
                MaxWheelSize = model.MaxWheelSize,
                MinWeight = model.MinWeight,
                MaxWeight = model.MaxWeight,
                MinNumberOfSpeeds = model.MinNumberOfSpeeds,
                MaxNumberOfSpeeds = model.MaxNumberOfSpeeds,
                Manufacturer = context.Bicycles.Select(x => x.Manufacturer).Distinct().ToList(),
                SelectedManufacturer = selectedManufacture,
            });
        }


        
        [HttpGet]
        public IActionResult Buy(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            ViewBag.VeloId = id;
            return View();
        }
        [HttpPost]
        public IActionResult Buy(Order order, int? id)
        {

            if (ModelState.IsValid)
            {
                order.BikeId = id;
                context.Orders.Add(order);
                context.SaveChanges();

                try
                {
                    Bike bike = context.Bicycles.FirstOrDefault(x => x.BikeId == order.BikeId);

                    MailAddress from = new MailAddress("teran5656@gmail.com");
                    MailAddress to = new MailAddress(order.Email);
                    MailMessage m = new MailMessage(from, to);
                    m.Subject = $"Онлайн магазин {"VeloOnline"}. Спасибо за покупку";
                    m.Body = $"Здраствуйте {order.Firstname}, Спасибо за покупку {bike.Title}";
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                    smtp.Credentials = new NetworkCredential("teran5656@gmail.com", "acer5735z");
                    smtp.EnableSsl = true;
                    smtp.Send(m);
                }
                catch (Exception ex) { }
                context.SaveChanges();

                return RedirectToAction("Index", new { mes = "Спасибо за покупку!" });
            }

            else
            {
                return View(order);
            }
        }

        public IActionResult ShowBike(int bikeId)
        {
            var bike = context.Bicycles.Find(bikeId);
            return View(bike);
        }

            
    }
}
