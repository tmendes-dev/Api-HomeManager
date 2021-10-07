using Domain.Aggregate;
using Domain.Repositories;
using System.Linq;

namespace Infra.Repositories
{
    public class ShopListRepository : IBasicRepository<ShopList>
    {
        private readonly ApplicationDbContext _dbContext;

        public ShopListRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Create(ShopList entity)
        {
            int id = _dbContext.ShopLists.Add(entity).Entity.ID;

            _dbContext.SaveChanges();

            return id;
        }

        public void Delete(ShopList entity)
        {
            _dbContext.ShopLists.Remove(entity);
        }

        public ShopList Retrieve(int id)
        {
            return _dbContext.ShopLists.Where(r => r.ID.Equals(id)).FirstOrDefault();
        }

        public ShopList Update(ShopList entity)
        {
            var entityResult = _dbContext.Update(entity).Entity;
            _dbContext.SaveChanges();

            return entityResult;
        }
    }
}