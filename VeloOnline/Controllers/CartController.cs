using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeloOnline.Extensions;
using VeloOnline.Models;
using VeloOnline.Models.ViewModels;

namespace VeloOnline.Controllers
{
    public class CartController : Controller
    {
        BikeContext context;
        public CartController(BikeContext context)
        {
            this.context = context;
        }
        public IActionResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = GetCart(),
                ReturnUrl = returnUrl
            });
        }

        public IActionResult AddToCart(int bikeId, string returnUrl, string page)
        {
            returnUrl = returnUrl.Replace("BikeList", "Index/" + page);     //в js повесить обработчик на load BikeList с переданым id
            Bike bike = context.Bicycles.FirstOrDefault(x => x.BikeId == bikeId);
            if (bike != null)
            {
                var cart = GetCart();
                cart.AddItem(bike, 1);
                HttpContext.Session.SetObjectAsJson("Cart", cart);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public IActionResult DeleteItemFromCart(int bikeId, string returnUrl)
        {
            Bike bike = context.Bicycles.FirstOrDefault(x => x.BikeId == bikeId);
            if (bike != null)
            {
                var cart = GetCart();
                cart.RemoveItem(bike, 1);
                HttpContext.Session.SetObjectAsJson("Cart", cart);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public IActionResult RemoveFromCart(int bikeId, string returnUrl)
        {
            Bike bike = context.Bicycles.FirstOrDefault(x => x.BikeId == bikeId);
            if (bike != null)
            {
                var cart = GetCart();
                cart.RemoveLine(bike);
                HttpContext.Session.SetObjectAsJson("Cart", cart);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public IActionResult RemoveAllLines(string returnUrl)
        {
                var cart = GetCart();
                cart.Clear();
                HttpContext.Session.SetObjectAsJson("Cart", cart);
         
            return Redirect(returnUrl);
        }

        private Cart GetCart()
        {
            Cart cart = HttpContext.Session.GetObjectFromJson<Cart>("Cart");
            if (cart == null)
            {
                cart = new Cart();
                HttpContext.Session.SetObjectAsJson("Cart", cart);
            }
            return cart;
        }
    }
}
