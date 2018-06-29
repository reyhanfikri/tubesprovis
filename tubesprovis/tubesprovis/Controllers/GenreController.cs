using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace tubesprovis.Controllers
{
    [Produces("application/json")]
    [Route("api/Genre")]
    public class GenreController : Controller
    {
        // GET: api/DVD/getAllGenre
        [HttpGet("getAllGenre"), Authorize]
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
        [HttpGet("{id}"), Authorize]
        public IActionResult Get(int id)
        {
            var value = new Model.tb_Genre.Genre_Class();
            var RP = new Model.tb_Genre.Genre_Repo();

            value = RP.getById(id);

            if (value != null)
            {
                return Ok(value);
            }
            else
            {
                return NotFound();
            }


        }

        // POST: api/Genre
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Genre/5
        [HttpPut("{id}/{newGenre}"), Authorize]
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

        // DELETE: api/Genre/Delete/5
        [HttpDelete("Delete/{id}"), Authorize]
        public IActionResult Delete(int id)
        {


            var RP = new Model.tb_Genre.Genre_Repo();
            var value = new Model.tb_Genre.Genre_Class();


            if (RP.getById(id) != null)
            {

                RP.DeleteGenre(id);
                return Ok("ID Terhapus");
            }
            else
            {
                return NotFound();
            }
        }
    }
}
