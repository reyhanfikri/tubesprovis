﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace tubesprovis.Controllers
{
    [Produces("application/json")]
    [Route("api/GambarDVD")]
    public class GambarDVDController : Controller
    {
        // GET: api/GambarDVD/getAllCover
        [HttpGet("getAllCover")]
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
        [HttpGet("{id}")]
        public string Get(int id)
        {

            return "value";
        }

        // GET: GambarDVD/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        // POST: api/GambarDVD
        [HttpPost("insert")]
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
        [HttpPut("{id}")]
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