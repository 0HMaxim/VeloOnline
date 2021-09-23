using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeloOnline.Models;
using VeloOnline.Models.ViewModels;

namespace VeloOnline.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<User> userManager;
        public UserController(UserManager<User> userManager)
        {
            this.userManager = userManager;
        }
        public IActionResult Index()
        {
            return View(userManager.Users.ToList());
        }

        [HttpPost]
        public async Task<IActionResult> EditUser(EditUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = userManager.FindByIdAsync(model.User.Id).Result ?? userManager.FindByNameAsync(model.User.UserName).Result;

                if (user != null)
                {
                    user.Email = model.User.Email;
                    await userManager.UpdateAsync(user);
                    return RedirectToAction("Index", new { model.ReturnUrl });
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult EditUser(string id, string returnUrl = null)
        {
            var user = userManager.FindByIdAsync(id).Result ?? userManager.FindByNameAsync(id).Result;
            return View(new EditUserViewModel
            {
                User = user,
                ReturnUrl = returnUrl
            });
        }


    [Authorize (Roles="admin")]
        [HttpGet]
        public IActionResult CreateUser(string id, string returnUrl = null)
        {
            if (id == null)
            {
                return View(new RegistrationViewModel { ReturnUrl = returnUrl });
            }
            else
            {
                var user = userManager.FindByIdAsync(id).Result ?? userManager.FindByNameAsync(id).Result;
               
                return View(new EditUserViewModel { User = user, ReturnUrl = returnUrl });
            }
        }
    [Authorize (Roles="admin")]
        [HttpPost]
        public async Task<IActionResult> CreateUser(RegistrationViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var user = model.User;

                IdentityResult result = await userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", new { returnUrl });
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(model);
        }
    [Authorize (Roles="admin")]
        [HttpPost]
        public async Task<IActionResult> DeleteUser(string id, string returnUrl)
        {
            var user = userManager.FindByIdAsync(id).Result;
            await userManager.DeleteAsync(user);

            return RedirectToAction("Index", new { returnUrl });
        }

        public async Task<IActionResult> ChangePassword(string id, string returnUr)
        {
            var user = await userManager.FindByIdAsync(id) ?? await userManager.FindByNameAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(new ChangePasswordViewModel { User = user, ReturnUrl = returnUr });
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await userManager.FindByNameAsync(model.User.UserName);
                if (user != null)
                {
                    await userManager.RemovePasswordAsync(user);
                    IdentityResult result = await userManager.AddPasswordAsync(user, model.Password);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError(string.Empty, error.Description);
                        }
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "User not found");
                }
            }
            return View(model);
        }


    }
}
