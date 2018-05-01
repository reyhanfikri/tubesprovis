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
    [Route("api/Token")]
    public class TokenController : Controller
    {
        private IConfiguration _config;

        public TokenController(IConfiguration config)
        {
            _config = config;
        }

        [AllowAnonymous]
        [HttpPost("GetToken", Name = "GetToken")]
        public IActionResult GetToken([FromBody]LoginModel login)
        {
            IActionResult response = NotFound(login);
            RepoUserModel repoM = new RepoUserModel();
            RepoLoginmodel repoL = new RepoLoginmodel();


            var user = repoM.Authenticate(login);

            if (user != null)
            {
                var tokenString = repoL.BuildToken(_config, user);
                response = Ok(new { token = tokenString });
            }
            return response;
        }
    }
}
