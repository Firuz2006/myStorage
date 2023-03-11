using Otchet.Core.Models;
using Otchet.DataBase.Contexts;

namespace Otchet.Repository.CashRepository;

public class RateRepository:Repository<Rate>
{

    public RateRepository(MainDbContext context):base(context)
    {
        
    }
    public bool Add(Rate rate)
    {
        _dbSet.Add(rate);
        return true;
    }

    public List<Rate> GetAll()
    {
        return _dbSet.ToList();
    }
}