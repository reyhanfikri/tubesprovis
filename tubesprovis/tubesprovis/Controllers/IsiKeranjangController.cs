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
    [Route("api/IsiKeranjang")]
    public class IsiKeranjangController : Controller
    {
        // GET: api/IsiKeranjang
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/IsiKeranjang/id
        [HttpGet("Isi/{id}", Name = "IsiKeranjang")]
        public IActionResult GetIsiKeranjangByIDCust(int id)
        {
            List<Model.IsiKeranjang_Class> value = new List<Model.IsiKeranjang_Class>();
            var RP = new Model.IsiKeranjang_Repo();

            value = RP.getIsiKeranjang(id);

            if (value != null)
            {
                return Ok(value);
            }
            else
            {
                return NotFound();
            }


        }
        // POST: api/IsiKeranjang
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/IsiKeranjang/5
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
