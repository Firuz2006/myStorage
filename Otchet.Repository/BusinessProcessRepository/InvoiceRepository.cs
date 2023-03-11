using Application.Common.Abstractions;
using Otchet.Core.Models;
using Otchet.DataBase.Contexts;

namespace Otchet.Repository.BusinessProcessRepository;

public class InvoiceRepository:Repository<Invoice>,IInvoiceRepository
{

    public InvoiceRepository(MainDbContext context):base(context)
    {
        
    }
    public bool Buy(Invoice invoice)
    {
        _dbSet.Add(invoice);
        return true;
    }

    public override bool Update(Invoice invoice)
    {
        _dbSet.Update(invoice);
        return true;
    }
    
    public override bool Delete(int id)
    {
        var invoice =_dbSet.SingleOrDefault(c => c.Id == id);
        if (invoice == null)return false;
        _dbSet.Remove(invoice);
        return true;
    }
    
}