using Microsoft.EntityFrameworkCore;
using Otchet.Core.Models;
using Otchet.DataBase.Contexts;

namespace Otchet.Repository.SimpleEntitiesRepository;

public class ProductRepository
{
    private readonly MainDbContext _context = new();
    
    public bool Add(Product product)
    {
        _context.Products.Add(product);
        _context.SaveChanges();
        return true;
    }

    public bool Update(Product product)
    {
        _context.Products.Update(product);
        _context.SaveChanges();
        return true;
    }

    public async Task<List<Product>> GetProducts() =>await _context.Products.ToListAsync();

    public bool Delete(int id)
    {
        var product = _context.Products.SingleOrDefault(c => c.Id == id);
        if (product == null)return false;
        
        _context.Products.Remove(product);
        return true;
    }
}