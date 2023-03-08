using Microsoft.EntityFrameworkCore;
using Otchet.Core.Models;
using Otchet.DataBase.Contexts;

namespace Otchet.Repository.SimpleEntitiesRepository;

public class CategoryRepository
{
    private readonly MainDbContext _context = new();

    public bool Add(Category category)
    {
        _context.Categories.Add(category);
        _context.SaveChanges();
        return true;
    }

    public bool Update(Category category)
    {
        _context.Categories.Update(category);
        _context.SaveChanges();
        return true;
    }

    public async Task<List<Category>> GetCategory() =>await _context.Categories.ToListAsync();

    public bool Delete(int id)
    {
        var category = _context.Categories.SingleOrDefault(c => c.Id == id);
        if (category == null)return false;
        
        _context.Categories.Remove(category);
        return true;
    }
}