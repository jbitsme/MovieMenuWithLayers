﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieMenuBLL;
using MovieMenuBLL.BO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieRestAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class RentalController : Controller
    {
        BLLFacade facade = new BLLFacade();
        // GET: api/values
        [HttpGet]
        public IEnumerable<RentalBO> Get()
        {
            return facade.RentalService.getAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public RentalBO Get(int id)
        {
            return facade.RentalService.get(id);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]RentalBO rental)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(facade.RentalService.Create(rental));
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]RentalBO rental)
        {
            if (id != rental.Id)
            {
                return BadRequest("Path id does not match a movie");
            }
            try
            {
                var rentalUpdated = facade.RentalService.Update(rental);
                return Ok(rentalUpdated);
            }
            catch(InvalidOperationException e)
            {
                return StatusCode(404, e.Message);
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            facade.RentalService.Delete(id);
        }
    }
}
