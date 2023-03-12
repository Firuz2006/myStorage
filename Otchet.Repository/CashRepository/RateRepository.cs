using Otchet.Core.Models;

namespace Otchet.Repository.CashRepository;

public class RateRepository
{
    private readonly DataBase.Contexts.MainDbContext _context = new();
    public bool Add(Rate rate)
    {
        _context.Rates.Add(rate);
        return true;
    }

    public List<Rate> GetAll()
    {
        return _context.Rates.ToList();
    }
}