using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeloOnline.Models;

namespace VeloOnline.Controllers.Api
{
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    public class BikeController : Controller
    {
        private readonly BikeContext context;
        
        public BikeController(BikeContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bike>>> Get()
        {
            return await context.Bicycles.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Bike>> Get(int id)
        {
            Bike bike = await context.Bicycles.FirstOrDefaultAsync(x => x.BikeId == id);
            if (bike == null)
            {
                return NotFound();
            }

            return Ok(bike);
        }

        
        [HttpPost]
        public async Task<ActionResult<Bike>> Post(Bike bike)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.Bicycles.Add(bike);
            await context.SaveChangesAsync();
            return Ok(bike);
        }

        [HttpPut]
        public async Task<ActionResult<Bike>> Put(Bike bike)
        {
            context.Update(bike);
            await context.SaveChangesAsync();
            return Ok(bike);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Bike>> Delete(int id)
        {
            Bike bike = await context.Bicycles.FirstOrDefaultAsync(x => x.BikeId == id);
            if (bike == null)
            {
                return NotFound();
            }
            context.Bicycles.Remove(bike);
            await context.SaveChangesAsync();
            return Ok(bike);
        }
    }
}
