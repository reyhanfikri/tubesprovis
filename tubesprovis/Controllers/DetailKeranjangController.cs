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
    [Route("api/DetailKeranjang")]
    public class DetailKeranjangController : Controller
    {
        // GET: api/DetailKeranjang/getAllDetailKeranjang
        [HttpGet("getAllDetailKeranjang"), Authorize]
        public IActionResult GetAllDetailKeranjang()
        {
            var listdetailkeranjang = new List<Model.tb_Detail_Keranjang.DetailKeranjang_Class>();
            var repositorydetailkeranjang = new Model.tb_Detail_Keranjang.DetailKeranjang_Repo();

            try
            {
                listdetailkeranjang = repositorydetailkeranjang.getAllDetailKeranjang();
            }
            catch (Exception ex)
            {

            }

            if (listdetailkeranjang == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(listdetailkeranjang);
            }

        }

        // GET: api/DetailKeranjang/5
        [HttpGet("{id}"), Authorize]
        public IActionResult Get(int id)
        {
            var value = new Model.tb_Detail_Keranjang.DetailKeranjang_Class();
            var RP = new Model.tb_Detail_Keranjang.DetailKeranjang_Repo();

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

        // POST: api/DetailKeranjang
        [HttpPost("insert"), Authorize]
        public IActionResult Post([FromBody]Model.tb_Detail_Keranjang.DetailKeranjang_Class value)
        {
            var RP = new Model.tb_Detail_Keranjang.DetailKeranjang_Repo();

            try
            {
                RP.insertDetailKeranjang(value);
                return Created("",value);
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        // PUT: api/DetailKeranjang/5
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
