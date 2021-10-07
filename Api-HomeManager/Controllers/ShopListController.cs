using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_HomeManager.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ShopListController : ControllerBase
    {
        [HttpGet]
        public IActionResult Test()
        {
            return Ok("Test!");
        }
    }
}
