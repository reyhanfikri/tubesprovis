using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace tubesprovis.Controllers
{
    [Produces("application/json")]
    [Route("api/DVD")]
    public class DVDController : Controller
    {
        // GET: api/DVD/getAllDVD
        [HttpGet("getAllDVD")]
        public IEnumerable<Model.tb_DVD.DVD_Class> GetAllDVD()
        {
            var listdvd = new List<Model.tb_DVD.DVD_Class>();
            var repositorydvd = new Model.tb_DVD.DVD_Repo();

            try
            {
                listdvd = repositorydvd.getAllDVD();
            }
            catch (Exception ex)
            {
            }
            return listdvd;
        }

        // GET: api/DVD/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/DVD
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/DVD/5
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
