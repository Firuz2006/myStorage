using System.Collections;
using Application.Common.Abstractions;
using Microsoft.EntityFrameworkCore;
using Otchet.Core.Models;
using Otchet.DataBase.Contexts;

namespace Otchet.Repository.SimpleEntitiesRepository;

public class UnitRepository:Repository<Unit>,IUnitRepository
{

    public UnitRepository(MainDbContext context) :base (context)
    {
        
    }

    public bool Add(Unit unit)
    {
        _dbSet.Add(unit);
        return true;
    }

    public bool Update(Unit unit)
    {
        _dbSet.Update(unit);
        return true;
    }

    public async Task<List<Unit>> GetAll() => await _dbSet.ToListAsync();

    public bool Delete(int id)
    {
        var unit = _dbSet.SingleOrDefault(c => c.Id == id);
        if (unit == null)return false;
        
        _dbSet.Remove(unit);
        return true;
    }

}