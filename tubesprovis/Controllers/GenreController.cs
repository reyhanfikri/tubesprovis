using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace tubesprovis.Controllers
{
    [Produces("application/json")]
    [Route("api/Genre")]
    public class GenreController : Controller
    {
        // GET: api/DVD/getAllGenre
        [HttpGet("getAllGenre")]
        public IActionResult GetAllGenre()
        {
            var listgenre = new List<Model.tb_Genre.Genre_Class>();
            var repositorygenre = new Model.tb_Genre.Genre_Repo();

            try
            {
                listgenre = repositorygenre.getAllGenre();
            }
            catch (Exception ex)
            {
            }
            if (listgenre == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(listgenre);
            }
        }

        // GET: api/Genre/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Genre
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Genre/5
        [HttpPut("{id}/{newGenre}")]
        public IActionResult Put(int Id, string Genre)
        {
            var RP = new Model.tb_Genre.Genre_Repo();

            try
            {
                RP.updateNamaGenre(Id, Genre);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
