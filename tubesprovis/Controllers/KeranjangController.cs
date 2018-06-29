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
        [HttpGet("{id}"), Authorize]
        public IActionResult Get(int id)
        {
            var value = new Model.tb_Keranjang.Keranjang_Class();
            var RP = new Model.tb_Keranjang.Keranjang_Repo();

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
        // GET: api/Keranjang/5
        [HttpGet("Cust/{id}",Name ="ByCustomerID"), Authorize]
        public IActionResult GetByidCust(int id)
        {
            var value = new Model.tb_Keranjang.Keranjang_Class();
            var RP = new Model.tb_Keranjang.Keranjang_Repo();

            value = RP.getByIdCust(id);

            if (value != null)
            {
                return Ok(value);
            }
            else
            {
                return NotFound();
            }


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

        // DELETE: api/Keranjang/Delete/5
        [HttpDelete("Delete/{id}"), Authorize]
        public IActionResult Delete(int id)
        {


            var RP = new Model.tb_Keranjang.Keranjang_Repo();
            var value = new Model.tb_Keranjang.Keranjang_Class();


            if (RP.getById(id) != null)
            {

                RP.DeleteKeranjang(id);
                return Ok("ID Terhapus");
            }
            else
            {
                return NotFound();
            }
        }
    }
}
