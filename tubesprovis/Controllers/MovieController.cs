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
        public IEnumerable<Model.tb_Movie.Movie_Class> GetAllMovie()
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
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Movie
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Movie/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
