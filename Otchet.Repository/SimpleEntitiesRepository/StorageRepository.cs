using Microsoft.EntityFrameworkCore;
using Otchet.Core.Models;
using Otchet.DataBase.Contexts;

namespace Otchet.Repository.SimpleEntitiesRepository;

public class StorageRepository
{
    private readonly MainDbContext _context = new();
    public bool Add(Storage storage)
    {
        _context.Storages.Add(storage);
        _context.SaveChanges();
        return true;
    }

    public bool Update(Storage storage)
    {
        _context.Storages.Update(storage);
        _context.SaveChanges();
        return true;
    }

    public async Task<List<Storage>> GetStorage() =>await _context.Storages.ToListAsync();

    public bool Delete(int id)
    {
        var storage = _context.Storages.SingleOrDefault(c => c.Id == id);
        if (storage == null)return false;
        
        _context.Storages.Remove(storage);
        return true;
    }
}