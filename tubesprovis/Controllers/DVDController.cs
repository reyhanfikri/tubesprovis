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
        public IActionResult GetAllDVD()
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

            if (listdvd == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(listdvd);
            }
        }

        // GET: api/DVD/5
        [HttpGet("{id}")]
        public string Get(int id)
        {

            return "value";
        }

        // POST: api/DVD
        [HttpPost("insert")]
        public IActionResult Post([FromBody]Model.tb_DVD.DVD_Class value)
        {
            var RP = new Model.tb_DVD.DVD_Repo();

            try
            {
                RP.insertNewDVD(value);
                return Created("",value);
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }
        // PUT: api/DVD/5
        [HttpPut("{id}/{stock_berkurang}")]
        public string Put(int id,int stock_berkurang)
        {
            var RP = new Model.tb_DVD.DVD_Repo();

            try
            {
                RP.updateStockDVD(id,stock_berkurang);
                return "OK";
            }
            catch (Exception e)
            {
                return "FAIL";
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
