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
    [Route("api/GambarDVD")]
    public class GambarDVDController : Controller
    {
        // GET: api/GambarDVD/getAllCover
        [HttpGet("getAllCover"), Authorize]
        public IActionResult getAllCover()
        {
            var listcover = new List<Model.tb_Gambar_DVD.GambarDVD_Class>();
            var repositorycover = new Model.tb_Gambar_DVD.GambarDVD_Repo();

            try
            {
                listcover = repositorycover.getAllCover();
            }
            catch (Exception ex)
            {
            }
            
            if(listcover == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(listcover);
            }
        }

        // GET: api/GambarDVD/5
        [HttpGet("gambar/{id}",Name ="Gambar")]
        public IActionResult GetByGambar(int id)
        {
            var cover = new Model.tb_Gambar_DVD.GambarDVD_Class();
            var repositorycover = new Model.tb_Gambar_DVD.GambarDVD_Repo();

            try
            {
                cover = repositorycover.getCoverByIDGambar(id);
            }
            catch (Exception ex)
            {
            }

            if (cover == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(cover);
            }

        }

        // GET: api/GambarDVD/5
        [HttpGet("dvd/{id}",Name = "dvd")]
        public IActionResult GetByDVD(int id)
        {
            var cover = new Model.tb_Gambar_DVD.GambarDVD_Class();
            var repositorycover = new Model.tb_Gambar_DVD.GambarDVD_Repo();

            try
            {
                cover = repositorycover.getCoverByIDDVD(id);
            }
            catch (Exception ex)
            {
            }

            if (cover == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(cover);
            }
            
        }
        // GET: GambarDVD/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        // POST: api/GambarDVD
        [HttpPost("insert"), Authorize]
        public IActionResult Post([FromBody]Model.tb_Gambar_DVD.GambarDVD_Class value)
        {
            var RP = new Model.tb_Gambar_DVD.GambarDVD_Repo();

            try
            {
                RP.insertNewCover(value);
                return Created("", value);
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        // PUT: api/GambarDVD/5
        [HttpPut("{id}"), Authorize]
        public IActionResult Put(int id, string gambar_sampul)
        {
            var RP = new Model.tb_Gambar_DVD.GambarDVD_Repo();

            try
            {
                RP.updateCoverDVD(id, gambar_sampul);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}