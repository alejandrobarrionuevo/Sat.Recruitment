using Microsoft.AspNetCore.Mvc;
using Sat.Recruitment.Contracts;
using Sat.Recruitment.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Sat.Recruitment.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public partial class UsersController : ControllerBase
    {
        readonly IServiceManager _serviceManager;

        public UsersController(IServiceManager serviceManager) => _serviceManager = serviceManager;

        [HttpPost]
        [Route("/create-user")]
        public async Task<ActionResult> CreateUser(UserDTO newUser)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            else
            {
                await _serviceManager.UserService.CreateAsync(newUser);
                return Ok();
            }
        }
    }
}
