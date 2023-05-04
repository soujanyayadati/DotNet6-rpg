using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNet6_rpg.Data;
using DotNet6_rpg.Dtos.User;
using Microsoft.AspNetCore.Mvc;

namespace DotNet6_rpg.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
       private readonly IAuthRepository _authrepo;

        public AuthController(IAuthRepository authrepo)
        {
            _authrepo = authrepo;
        }

        [HttpPost("register")]
        public async Task<ActionResult<ServiceResponse<int>>> Register(UserRegisterDto request)
        {
            var response = await _authrepo.Register(
                new User { Username = request.Username }, request.Password
            );

            if(!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpPost("login")]
        public async Task<ActionResult<ServiceResponse<string>>> Login(UserLoginDto request)
        {
            var response = await _authrepo.Login(request.Username, request.Password);
            if(!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }
    }
}