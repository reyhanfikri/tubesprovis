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
    [Route("api/Customer")]
    public class CustomerController : Controller
    {
        // GET: api/Customer/getAllCustomer
        [HttpGet("getAllCustomer"), Authorize]
        public IActionResult GetAllCustomer()
        {
            var listcustomer = new List<Model.tb_Customer.Cust_Class>();
            var repositorycust = new Model.tb_Customer.Cust_Repo();

            try
            {
                listcustomer = repositorycust.getAllCustomer();
            }
            catch (Exception ex)
            {
            }
            if (listcustomer == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(listcustomer);
            }
        }

        // GET: api/Customer/5
        [HttpGet("{id}"), Authorize]
        public IActionResult Get(int id)
        {
            var value = new Model.tb_Customer.Cust_Class();
            var RP = new Model.tb_Customer.Cust_Repo();

            value = RP.getById(id);

            if(value != null)
            {
                return Ok(value);
            }
            else
            {
                return NotFound();
            }
            
            
        }

        // POST: api/Customer
        [HttpPost("Insert"), Authorize]
        public IActionResult Post([FromBody]Model.tb_Customer.Cust_Class value)
        {
            var RP = new Model.tb_Customer.Cust_Repo();

            try
            {
                RP.insertNewCustomer(value);
                return Created("",value);
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        // PUT: api/Customer/5
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
