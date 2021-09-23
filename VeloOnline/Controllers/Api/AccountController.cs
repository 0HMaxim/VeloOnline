using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using VeloOnline.Config;
using VeloOnline.Models;

namespace VeloOnline.Controllers.Api
{
    public class LocalUser
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }

    [ApiController]
    [Route("api/[controller]/[action]")]
    public class AccountController : Controller
    {
        private readonly SignInManager<User> signInManager;
        private readonly UserManager<User> userManager;

        public AccountController(SignInManager<User> signInManager, UserManager<User> userManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
        }
        [HttpPost]
        public IActionResult Token(LocalUser localUser)
        {
            var result = signInManager.PasswordSignInAsync(localUser.Login, localUser.Password, false, false).Result;
            ClaimsIdentity identity = null;
            if (result.Succeeded)
            {
                var user = userManager.FindByNameAsync(localUser.Login).Result;

                identity = GetIdentity(user);
            }
            else
            {
                ModelState.AddModelError("Login", "Invalid login or password");
                ModelState.AddModelError("Password", "Invalid login or password");
                return BadRequest();
            }

            var jwt = new JwtSecurityToken(
                issuer: AuthenticationOptions.ISSUER,
                audience: AuthenticationOptions.AUDIENCE,
                claims: identity.Claims,
                expires: DateTime.Now.AddMinutes(AuthenticationOptions.LIFETIME),
                signingCredentials: new SigningCredentials(AuthenticationOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256)
                );


            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);
            return Json(new
            {
                access_token = encodedJwt
            });
        }


        private ClaimsIdentity GetIdentity(User user)
        {
            var claims = new List<Claim>
                {
                    new Claim(ClaimsIdentity.DefaultNameClaimType, user.UserName),
                };
            ClaimsIdentity claimsIdentity =
                new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            return claimsIdentity;
        }

    }
}
