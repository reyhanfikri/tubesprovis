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
    [Route("api/Dictionary")]
    public class DictionaryController : Controller
    {
        // GET: api/Dictionary/getDictionary
        [HttpGet("getDictionary"), Authorize]
        public IActionResult GetDictionary()
        {
            var listdictionary = new List<Model.tb_dictionary.Dictionary_class>();
            var repositorydict = new Model.tb_dictionary.Dictionary_repo();

            try
            {
                listdictionary = repositorydict.getDictionary();
            }
            catch (Exception ex)
            {
            }
            if (listdictionary == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(listdictionary);
            }
        }

        // PUT: api/Dictionary/5
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