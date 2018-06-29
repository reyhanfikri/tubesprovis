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
    [Route("api/Movie")]
    public class MovieController : Controller
    {
        // GET: api/DVD/getAllMovie
        [HttpGet("getAllMovie"), Authorize]
        public IActionResult GetAllMovie()
        {
            var listmovie = new List<Model.tb_Movie.Movie_Class>();
            var repositorymovie = new Model.tb_Movie.Movie_Repo();

            try
            {
                listmovie = repositorymovie.getAllMovie();
            }
            catch (Exception ex)
            {
            }

            if (listmovie == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(listmovie);
            }
        }

        // GET: api/DVD/getAllNamaAndIDMovie
        [HttpGet("getAllNamaAndIDMovie"), Authorize]
        public IActionResult getAllNamaAndIDMovie()
        {
            var listmovie = new List<Model.tb_Movie.Movie_Class>();
            var repositorymovie = new Model.tb_Movie.Movie_Repo();

            try
            {
                listmovie = repositorymovie.getAllNamaAndIDMovie();
            }
            catch (Exception ex)
            {
            }
            if(listmovie == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(listmovie);
            }
       
        }

        // GET: api/Movie/5
        [HttpGet("{id}"), Authorize]
        public IActionResult Get(int id)
        {
            var value = new Model.tb_Movie.Movie_Class();
            var RP = new Model.tb_Movie.Movie_Repo();
            value = RP.getById(id);

            if(value != null)
            {
                return Ok(value);
            }
            else
            {
                return NotFound();
            }
            

        }

        // POST: api/Movie/insert
        [HttpPost("Insert"), Authorize]
        public IActionResult Post([FromBody]Model.tb_Movie.Movie_Class value)
        {
            var RP = new Model.tb_Movie.Movie_Repo();

            try
            {
                RP.insertNewMovie(value);
                return Created("",value);
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        // PUT: api/Movie/5
        [HttpPut("{id}/{newJudul}"), Authorize]
        public IActionResult Put(int Id, string Judul)
        {
            var RP = new Model.tb_Movie.Movie_Repo();

            try
            {
                RP.updateJudulMovie(Id, Judul);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        // DELETE: api/Movie/Delete/5
        [HttpDelete("Delete/{id}"), Authorize]
        public IActionResult Delete(int id)
        {


            var RP = new Model.tb_Movie.Movie_Repo();
            var value = new Model.tb_Movie.Movie_Class();


            if (RP.getById(id) != null)
            {

                RP.deleteMovieById(id);
                return Ok("ID Terhapus");
            }
            else
            {
                return NotFound();
            }
        }
    }
}
