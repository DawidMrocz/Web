
using Domain.Abstractions;
using Domain.Entities;

namespace Infrastructure.Repositories
{
    public sealed class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public ProductRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Insert(Product product)
        {
            _dbContext.Set<Product>().Add(product);
        }
    }
}
