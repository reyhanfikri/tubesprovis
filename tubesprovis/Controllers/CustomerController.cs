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
        //// GET: api/Customer/Nama
        //[HttpGet("Nama/{Nama}",Name = "GetbyNama"), Authorize]
        //public IActionResult GetCustomerByNama(String Nama)
        //{
        //    try
        //    {
        //        char[] Input = new char[Nama.Length];

        //        int i;
        //        for ( i = 0; i < Nama.Length; i++)
        //        {


        //            if (Nama[i] == '_')
        //            {
        //                Input[i] = ' ';
        //            }
        //            else
        //            {
        //                Input[i] = Nama[i];
        //            }
        //        }
        //        Input[i] = '\0';

        //        var value = new Model.tb_Customer.Cust_Class();
        //        var RP = new Model.tb_Customer.Cust_Repo();
        //        String input = new string(Input);
        //        value = RP.getByNama(input);

        //        if (value != null)
        //        {
        //            return Ok(value);
        //        }
        //        else
        //        {
        //            return Ok(input);
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }

        //    return BadRequest();

        //}

        // GET: api/Customer/Username
        [HttpGet("Username/{Username}", Name = "GetbyNama"), Authorize]
        public IActionResult GetCustomerByNama(String Username)
        {
            try
            {
                
                var value = new Model.tb_Customer.Cust_Class();
                var RP = new Model.tb_Customer.Cust_Repo();
                
                value = RP.getByUsername(Username);

                if (value != null)
                {
                    return Ok(value);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return BadRequest();

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
