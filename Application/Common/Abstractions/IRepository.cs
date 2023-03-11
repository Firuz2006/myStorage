using Otchet.Core.Models;

namespace Application.Common.Abstractions;

public interface IRepository<TEntity> where  TEntity:EntityBase
{
    bool Add(TEntity entity);
    bool Update(TEntity entity);
    Task<List<TEntity>> GetAll();
    bool Delete(int id);
}