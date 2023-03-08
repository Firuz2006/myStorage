using System.Collections;
using Microsoft.EntityFrameworkCore;
using Otchet.Core.Models;
using Otchet.DataBase.Contexts;

namespace Otchet.Repository.SimpleEntitiesRepository;

public class UnitRepository
{private readonly MainDbContext _context = new();

    public bool Add(Unit unit)
    {
        _context.Units.Add(unit);
        _context.SaveChanges();
        return true;
    }

    public bool Update(Unit unit)
    {
        _context.Units.Update(unit);
        _context.SaveChanges();
        return true;
    }

    public async Task<List<Unit>> GetUnits() => await _context.Units.ToListAsync();

    public bool Delete(int id)
    {
        var unit = _context.Units.SingleOrDefault(c => c.Id == id);
        if (unit == null)return false;
        
        _context.Units.Remove(unit);
        return true;
    }

}