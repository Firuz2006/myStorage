using Application.Common.Abstractions;
using Microsoft.EntityFrameworkCore;
using Otchet.Core.Models;
using Otchet.DataBase.Contexts;

namespace Otchet.Repository.SimpleEntitiesRepository;

public class CategoryRepository:Repository<Category>,ICategoryRepository
{
    

    public CategoryRepository(MainDbContext context):base (context)
    {
        
    }
    public override bool Add(Category category)
    {
       _dbSet.Add(category);
        
        return true;
    }

    public override bool Update(Category category)
    {
        _dbSet.Update(category);
        return true;
    }

    public override async Task<List<Category>> GetAll() =>await _dbSet.ToListAsync();

    public override bool Delete(int id)
    {
        var category = _dbSet.SingleOrDefault(c => c.Id == id);
        if (category == null)return false;
        
        _dbSet.Remove(category);
        return true;
    }
}