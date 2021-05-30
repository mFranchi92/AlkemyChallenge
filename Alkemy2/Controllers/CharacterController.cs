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
    public class CharacterController : ControllerBase
    {
        public MyDbContext DbContext;
        public CharacterController(MyDbContext applicationDbContext)
        {
            DbContext = applicationDbContext;
        }
    
        // GET: api/<CharacterController>
        [HttpGet]
        public ActionResult<List<Characters>> characters()
        {
            var res = DbContext.Characters.ToList();
            return res;
        }

        // POST api/<CharacterController>
        [HttpPost]
        public ActionResult<Characters> AddCharacter([FromForm] Characters character)
        {
            DbContext.Characters.Add(character);
            DbContext.SaveChanges();
            return character;
        }

        // PUT api/<CharacterController>/5
        [HttpPut]
        public ActionResult<Characters> UpdateCharacter([FromForm] Characters character)
        {
            DbContext.SaveChanges();
            return character;
        }

        // DELETE api/<CharacterController>/5
        [HttpDelete]
        public ActionResult<bool> RemoveCharacterByID(int ID)
        {
            var res = DbContext.Characters.Where(a => a.ID == ID).FirstOrDefault();
            DbContext.Characters.Remove(res);
            DbContext.SaveChanges();
            return true;
        }
    }
}
