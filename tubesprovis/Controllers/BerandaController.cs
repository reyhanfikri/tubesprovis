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
    [Route("api/Beranda")]
    public class BerandaController : Controller
    {
        

        // GET: api/Beranda/5
        [HttpGet("{id}"), Authorize]
        public IActionResult Get(int id)
        {
            var listberanda = new List<Model.Beranda>();
            var repositoryBeranda = new Model.Beranda_Repo();

            listberanda = repositoryBeranda.GetBerandaByID(id);

            if (listberanda != null)
            {
                return Ok(listberanda);
            }
            else
            {
                return NotFound();
            }


        }

       
    }
}
