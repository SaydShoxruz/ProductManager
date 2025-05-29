using ProductManager.Models;
using ProductManager.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.Services;

public class AppService
{
    private readonly IProductRepository _productRepository;
    public AppService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    public async Task<Product> AddProductAsync(Product product)
    {
        return await _productRepository.CreateAsync(product);
    }
    public async Task<Product> GetProductAsync(int id)
    {
        return await _productRepository.GetAsync(p => p.Id == id);
    }
    public async Task<IEnumerable<Product>> GetAllProductsAsync(Expression<Func<Product, bool>> expression = null!)
    {
        return await _productRepository.GetAll(expression);
    }
    public async Task<Product> UpdateProductAsync(Product product)
    {
        return await _productRepository.UpdateAsync(product);
    }
    public async Task<bool> DeleteProductAsync(int id)
    {
        var product = await GetProductAsync(id);
        if (product == null) return false;

        return await _productRepository.DeleteAsync(product);
    }
}
