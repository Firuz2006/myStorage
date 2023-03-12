using Microsoft.EntityFrameworkCore;
using Otchet.Core.Models;
using Otchet.DataBase.Contexts;

namespace Otchet.Repository.SimpleEntitiesRepository;

public class FirmRepository
{
    private readonly MainDbContext _context = new();
    public bool Add(Firm firm)
    {
        _context.Firms.Add(firm);
        _context.SaveChanges();
        return true;
    }

    public bool Update(Firm firm)
    {
        _context.Firms.Update(firm);
        _context.SaveChanges();
        return true;
    }

    public async Task<List<Firm>> GetFirm() =>await _context.Firms.ToListAsync();

    public bool Delete(int id)
    {
        var firm = _context.Firms.SingleOrDefault(c => c.Id == id);
        if (firm == null)return false;
        
        _context.Firms.Remove(firm);
        return true;
    }
}