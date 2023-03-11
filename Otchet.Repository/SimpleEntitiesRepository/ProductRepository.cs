using Application.Common.Abstractions;
using Microsoft.EntityFrameworkCore;
using Otchet.Core.Models;
using Otchet.DataBase.Contexts;

namespace Otchet.Repository.SimpleEntitiesRepository;

public class ProductRepository:Repository<Product>,IProductRepository
{
    public ProductRepository(MainDbContext context) :base (context)
    {
        
    }
    private readonly MainDbContext _context = new();
    
    public override bool Add(Product product)
    {
        _dbSet.Add(product);
        return true;
    }

    public override bool Update(Product product)
    {
        _dbSet.Update(product);
        return true;
    }

    public override  async Task<List<Product>> GetAll() =>await _dbSet.ToListAsync();

    public override bool Delete(int id)
    {
        var product = _context.Products.SingleOrDefault(c => c.Id == id);
        if (product == null)return false;
        _dbSet.Remove(product);
        return true;
    }
}