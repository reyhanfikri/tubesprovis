using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace tubesprovis.Controllers
{
    [Produces("application/json")]
    [Route("api/Keranjang")]
    public class KeranjangController : Controller
    {
        // GET: api/DVD/getAllKeranjang
        [HttpGet("getAllKeranjang")]
        public IEnumerable<Model.tb_Keranjang.Keranjang_Class> GetAllKeranjang()
        {
            var listkeranjang = new List<Model.tb_Keranjang.Keranjang_Class>();
            var repositorykeranjang = new Model.tb_Keranjang.Keranjang_Repo();

            try
            {
                listkeranjang = repositorykeranjang.getAllKeranjang();
            }
            catch (Exception ex)
            {
            }
            return listkeranjang;
        }

        // GET: api/Keranjang/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Keranjang
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Keranjang/5
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
