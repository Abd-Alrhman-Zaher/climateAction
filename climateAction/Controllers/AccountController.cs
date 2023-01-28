using climateAction.Models;
using climateAction.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace climateAction.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        IAccountServices services;
        public AccountController(IAccountServices _services)
        {
            services = _services;
        }
        [HttpPost]
        [Route("CreateAccount")]
        public async Task<IActionResult> creat(signUpModel signUp)
        {
            var r = await services.createAccount(signUp);
            if (r.Succeeded)
            {
                return Ok("ok");
            }
            else
            {
                return Ok("some string");
            }
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> login([FromBody] SignInModel signIn)
        {
            var r = await services.login(signIn);

            if (string.IsNullOrEmpty(r))
            {
                return Unauthorized();
            }
            {
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));
                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                var tokeOptions = new JwtSecurityToken(
                    issuer: "http://localhost",
                    audience: "http://localhost",
                    claims: new List<Claim>(),
                    expires: DateTime.Now.AddMinutes(5),
                    signingCredentials: signinCredentials
                );
                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
                return Ok(new AuthenticatedResponse { Token = tokenString });
            }

        }
    }
}
