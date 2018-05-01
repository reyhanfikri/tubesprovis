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
        [HttpGet("{id}")]
        public Model.tb_Customer.Cust_Class Get(int id)
        {
            
            var RP = new Model.tb_Customer.Cust_Repo();

            Model.tb_Customer.Cust_Class value = RP.getById(id);

            return value;
            
        }

        // POST: api/Customer
        [HttpPost("Insert")]
        public string Post([FromBody]Model.tb_Customer.Cust_Class value)
        {
            var RP = new Model.tb_Customer.Cust_Repo();

            try
            {
                RP.insertNewCustomer(value);
                return "0K";
            }
            catch (Exception e)
            {
                return e.Message;
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
