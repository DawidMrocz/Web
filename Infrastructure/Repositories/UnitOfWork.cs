
using Domain.Abstractions;

namespace Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;
        public IProductRepository Products { get; }
        public UnitOfWork(ApplicationDbContext dbContext,
                            IProductRepository products)
        {
            _dbContext = dbContext;
            Products = products;
        }
        public void Dispose()
        {
            _dbContext.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
