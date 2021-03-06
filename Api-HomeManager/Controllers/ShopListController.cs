using Domain.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace Api_HomeManager.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShopListController : ControllerBase
    {
        private readonly IShopListService _service;
        private readonly ILogger<ShopListController> _logger;

        public ShopListController(IShopListService service, ILogger<ShopListController> logger)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public IActionResult Test()
        {
            try
            {
                return Ok("Test!");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in test method");
                throw;
            }
        }
    }
}