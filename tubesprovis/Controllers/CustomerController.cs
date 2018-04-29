using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace tubesprovis.Controllers
{
    [Produces("application/json")]
    [Route("api/Customer")]
    public class CustomerController : Controller
    {
        // GET: api/Customer/getAllCustomer
        [HttpGet("getAllCustomer")]
        public IEnumerable<Model.tb_Customer.Cust_Class> GetAllCustomer()
        {
            var listcustomer = new List<Model.tb_Customer.Cust_Class>();
            var repositorycust = new Model.tb_Customer.Cust_Repo();

            try
            {
                listcustomer = repositorycust.getAllCustomer();
            } catch (Exception ex)
            {
            }
            return listcustomer;
        }

        // GET: api/Customer/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Customer
        [HttpPost]
        public void Post([FromBody]string value)
        {
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
