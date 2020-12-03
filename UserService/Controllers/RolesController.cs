using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Database;

namespace UserService.Controllers
{
    [Route("api/users/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly DatabaseContext context;
        private readonly ILogger<UserController> _logger;

        public RolesController(DatabaseContext context, ILogger<UserController> logger)
        {
            this.context = context;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(context.Roles);
        }


    }
}