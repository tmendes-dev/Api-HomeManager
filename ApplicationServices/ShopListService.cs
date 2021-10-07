using Domain.Aggregate;
using Domain.Repositories;
using Domain.Services;
using Microsoft.Extensions.Logging;

namespace ApplicationServices
{
    public class ShopListService : IShopListService
    {
        private readonly IBasicRepository<ShopList> _repository;
        private readonly ILogger<ShopListService> _logger;

        public ShopListService(IBasicRepository<ShopList> repository, ILogger<ShopListService> logger)
        {
            _repository = repository;
            _logger = logger;
        }
    }
}