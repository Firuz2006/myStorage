using Microsoft.EntityFrameworkCore;
using Otchet.Core.Models;
using Otchet.DataBase.Contexts;

namespace Otchet.Repository.SimpleEntitiesRepository;

public class ClientRepository
{
    private readonly MainDbContext _context = new();
    public bool Add(Client client)
    {
        _context.Clients.Add(client);
        _context.SaveChanges();
        return true;
    }

    public bool Update(Client client)
    {
        _context.Clients.Update(client);
        _context.SaveChanges();
        return true;
    }

    public async Task<List<Client>> GetClients() =>await _context.Clients.ToListAsync();

    public bool Delete(int id)
    {
        var client = _context.Clients.SingleOrDefault(c => c.Id == id);
        if (client == null)return false;
        
        _context.Clients.Remove(client);
        return true;
    }
}