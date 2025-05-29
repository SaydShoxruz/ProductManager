using ProductManager.Context;
using ProductManager.Models;

namespace ProductManager.Repositories;

public class ProductRepository : Repository<Product>, IProductRepository
{
    private readonly AppDbContext _appDbContext;
    public ProductRepository(AppDbContext appDbContext) : base(appDbContext)
    {
        _appDbContext = appDbContext;
    }
}
