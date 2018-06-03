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
using System.Diagnostics;

namespace tubesprovis.Controllers
{
    [Produces("application/json")]
    [Route("api/Servis")]
    public class ServisController : Controller
    {
        // GET: api/Servis
        [HttpGet("GetBeranda",Name = "GEtberanda")]
        public IActionResult GetUy()
        {
            var value = new List<Model.Beranda>();
            var RP = new Model.Beranda_Repo();
            try
            {
                value = RP.Get();
            }
            catch (Exception ex)
            {
               
            }

            if (value != null)
            {
                return Ok(value);
            }
            else
            {
                return Unauthorized();
            }
        }

        // GET: api/Servis/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Servis
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Servis/5
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
