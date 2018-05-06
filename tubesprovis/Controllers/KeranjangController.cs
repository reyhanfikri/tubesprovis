using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace tubesprovis.Controllers
{
    [Produces("application/json")]
    [Route("api/Keranjang")]
    public class KeranjangController : Controller
    {
        // GET: api/DVD/getAllKeranjang
        [HttpGet("getAllKeranjang"), Authorize]
        public IActionResult GetAllKeranjang()
        {
            var listkeranjang = new List<Model.tb_Keranjang.Keranjang_Class>();
            var repositorykeranjang = new Model.tb_Keranjang.Keranjang_Repo();

            try
            {
                listkeranjang = repositorykeranjang.getAllKeranjang();
            }
            catch (Exception ex)
            {
            }

            if (listkeranjang == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(listkeranjang);
            }
        }

        // GET: api/Keranjang/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Keranjang/insert
        [HttpPost("insert"), Authorize]
        public IActionResult Post([FromBody]Model.tb_Keranjang.Keranjang_Class value)
        {
            var RP = new Model.tb_Keranjang.Keranjang_Repo();

            try
            {
                RP.insertKeranjang(value);
                return Created("",value);
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        // PUT: api/Keranjang/5
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
