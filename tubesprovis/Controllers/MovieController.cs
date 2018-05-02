using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace tubesprovis.Controllers
{
    [Produces("application/json")]
    [Route("api/Movie")]
    public class MovieController : Controller
    {
        // GET: api/DVD/getAllMovie
        [HttpGet("getAllMovie")]
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

        // GET: api/DVD/getAllMovie
        [HttpGet("getAllMovieAndID")]
        public IEnumerable<Model.tb_Movie.Movie_Class> GetAllMovieAndID()
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
            return listmovie;
        }

        // GET: api/Movie/5
        [HttpGet("{id}")]
        public Model.tb_Movie.Movie_Class Get(int id)
        {

            var RP = new Model.tb_Movie.Movie_Repo();
            Model.tb_Movie.Movie_Class value = RP.getById(id);
            return value;

        }

        // POST: api/Movie/insert
        [HttpPost("Insert")]
        public string Post([FromBody]Model.tb_Movie.Movie_Class value)
        {
            var RP = new Model.tb_Movie.Movie_Repo();

            try
            {
                RP.insertNewMovie(value);
                return "0K";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        // PUT: api/Movie/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            var RP = new Model.tb_Movie.Movie_Repo();

            try
            {
                RP.deleteMovieById(id);
                return "0K";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
