﻿using System;
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
    [Route("api/DVD")]
    public class DVDController : Controller
    {
        // GET: api/DVD/getAllDVD
        [HttpGet("getAllDVD"), Authorize]
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
        [HttpGet("{id}"), Authorize]
        public IActionResult Get(int id)
        {
            var value = new Model.tb_DVD.DVD_Class();
            var RP = new Model.tb_DVD.DVD_Repo();

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

        // POST: api/DVD
        [HttpPost("insert"), Authorize]
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
        [HttpPut("{id}/{stock_berkurang}"), Authorize]
        public IActionResult Put(int id,int stock_berkurang)
        {
            var RP = new Model.tb_DVD.DVD_Repo();

            try
            {
                RP.updateStockDVD(id,stock_berkurang);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        // DELETE: api/DVD/Delete/5
        [HttpDelete("Delete/{id}"), Authorize]
        public IActionResult Delete(int id)
        {


            var RP = new Model.tb_DVD.DVD_Repo();
            var value = new Model.tb_DVD.DVD_Class();


            if (RP.getById(id) != null)
            {

                RP.DeleteDVD(id);
                return Ok("ID Terhapus");
            }
            else
            {
                return NotFound();
            }
        }
    }
}
