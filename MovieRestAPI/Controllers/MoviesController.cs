using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieMenuBLL;
using MovieMenuBLL.BO;

namespace MovieRestAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Movies")]
    public class MoviesController : Controller
    {
        BLLFacade facade = new BLLFacade();
        // GET: api/Movies
        [HttpGet]
        public IEnumerable<MovieBO> Get()
        {
            return facade.MovieService.getAll();
        }

        // GET: api/Movies/5
        [HttpGet("{id}", Name = "Get")]
        public MovieBO Get(int id)
        {
            return facade.MovieService.get(id);
        }
        
        // POST: api/Movies
        [HttpPost]
        public IActionResult Post([FromBody]MovieBO mov)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(facade.MovieService.Create(mov));
        }
        
        // PUT: api/Movies/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]MovieBO mov)
        {
            if( id != mov.Id)
            {
                return BadRequest("Id is not the same");
            }
            try
            {
                return Ok(facade.MovieService.Update(mov));
            }
            catch(InvalidOperationException e)
            {
                return StatusCode(404, e.Message);
            }
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            facade.MovieService.Delete(id);
        }
    }
}
