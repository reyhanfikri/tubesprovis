using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace tubesprovis.Controllers
{
    [Produces("application/json")]
    [Route("api/DetailKeranjang")]
    public class DetailKeranjangController : Controller
    {
        // GET: api/DetailKeranjang/getAllDetailKeranjang
        [HttpGet("getAllDetailKeranjang")]
        public IEnumerable<Model.tb_Detail_Keranjang.DetailKeranjang_Class> GetAllDetailKeranjang()
        {
            var listdetailkeranjang = new List<Model.tb_Detail_Keranjang.DetailKeranjang_Class>();
            var repositorydetailkeranjang = new Model.tb_Detail_Keranjang.DetailKeranjang_Repo();

            try
            {
                listdetailkeranjang = repositorydetailkeranjang.getAllDetailKeranjang();
            }
            catch (Exception ex)
            {
            }
            return listdetailkeranjang;
        }

        // GET: api/DetailKeranjang/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/DetailKeranjang
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/DetailKeranjang/5
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
