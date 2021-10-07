using Domain.Aggregate;
using Domain.Repositories;
using System.Linq;

namespace Infra.Repositories
{
    public class ProductRepository : IBasicRepository<Product>
    {
        private readonly ApplicationDbContext _dbContext;

        public ProductRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Create(Product entity)
        {
            int id = _dbContext.Products.Add(entity).Entity.ID;

            _dbContext.SaveChanges();

            return id;
        }

        public void Delete(Product entity)
        {
            _dbContext.Products.Remove(entity);
        }

        public Product Retrieve(int id)
        {
            return _dbContext.Products.Where(r => r.ID.Equals(id)).FirstOrDefault();
        }

        public Product Update(Product entity)
        {
            var entityResult = _dbContext.Update(entity).Entity;
            _dbContext.SaveChanges();

            return entityResult;
        }
    }
}