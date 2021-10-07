using Domain.Aggregate;
using Domain.Repositories;
using Domain.Services;
using Microsoft.Extensions.Logging;

namespace ApplicationServices
{
    public class ProductService : IProductService
    {
        private readonly IBasicRepository<Product> _repository;
        private readonly ILogger<ProductService> _logger;

        public ProductService(IBasicRepository<Product> repository, ILogger<ProductService> logger)
        {
            _repository = repository;
            _logger = logger;
        }
    }
}