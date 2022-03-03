using System;
using System.Threading.Tasks;
using Dotnet_rpg3.Data;
using Dotnet_rpg3.DTOs.User;
using Dotnet_rpg3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet_rpg3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepository;
        public AuthController(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }


        [HttpPost("Register")]
        public async Task<ActionResult<ServiceResponse<Guid>>> Register(AddUserDTO request)
        {
            var response = await _authRepository.Register(
                new User { UserName = request.Username },
                request.Password
            );

            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        [HttpPost("Login")]
        public async Task<ActionResult<ServiceResponse<Guid>>> Login(UserLoginDTO request)
        {
            var response = await _authRepository.Login(
                request.Username,
                request.Password
            );

            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }
    }
}