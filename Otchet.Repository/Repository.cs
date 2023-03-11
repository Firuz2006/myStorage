using Application.Common.Abstractions;
using Microsoft.EntityFrameworkCore;
using Otchet.Core.Models;
using Otchet.DataBase.Contexts;

namespace Otchet.Repository;

public abstract class Repository<TEntity>:IRepository<TEntity> where TEntity : EntityBase
{
    private readonly MainDbContext _context;
    protected DbSet<TEntity> _dbSet;

    public Repository(MainDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<TEntity>();
    }
    public virtual bool Add(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public virtual bool Update(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public virtual Task<List<TEntity>> GetAll()
    {
        throw new NotImplementedException();
    }

    public virtual bool Delete(int id)
    {
        throw new NotImplementedException();
    }
}