using Otchet.Core.Models;
using Otchet.DataBase.Contexts;

namespace Otchet.Repository.BusinessProcessRepository;

public class InvoiceRepository
{
    private readonly MainDbContext _context = new();
    
    public bool Buy(Invoice invoice)
    {
        _context.Invoices.Add(invoice);
        return true;
    }

    public bool Update(Invoice invoice)
    {
        _context.Invoices.Update(invoice);
        return true;
    }
    
    public bool Delete(Invoice invoice)
    {
        _context.Invoices.Remove(invoice);
        return true;
    }
    
}