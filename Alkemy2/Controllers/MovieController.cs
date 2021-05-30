using Alkemy2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Alkemy2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        public MyDbContext DbContext;
        public MovieController(MyDbContext myDbContext)
        {
            DbContext = myDbContext;
        }

        // GET: api/<CharacterController>
        [HttpGet]
        public ActionResult<List<Movies>> movies()
        {
            var res = DbContext.Movies.ToList();
            return res;
        }

        // POST api/<CharacterController>
        [HttpPost]
        public ActionResult<Movies> AddCharacter([FromForm] Movies movie)
        {
            DbContext.Movies.Add(movie);
            DbContext.SaveChanges();
            return movie;
        }

        // PUT api/<CharacterController>/5
        [HttpPut]
        public ActionResult<Movies> UpdateCharacter([FromForm] Movies movie)
        {
            DbContext.SaveChanges();
            return movie;
        }

        // DELETE api/<CharacterController>/5
        [HttpDelete]
        public ActionResult<bool> RemoveMovieByID(int ID)
        {
            var res = DbContext.Movies.Where(a => a.ID == ID).FirstOrDefault();
            DbContext.Movies.Remove(res);
            DbContext.SaveChanges();
            return true;
        }
    }
}
