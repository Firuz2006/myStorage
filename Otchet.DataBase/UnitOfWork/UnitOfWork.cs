using Application.Common.Abstractions;
using Otchet.Core.Models;
using Otchet.DataBase.Contexts;

namespace Otchet.DataBase.UnitOfWork;

public class UnitOfWork:IUnitOfWork
{
    private readonly MainDbContext _context;

    public ICategoryRepository Categorys { get; }
    public IInvoiceRepository Invoices{ get; }
    public IProductRepository Products { get; }
    public ISaleRepository Sales { get; }
    public IUnitRepository Units { get; }
    public UnitOfWork(MainDbContext context)
    {
        _context = context;
        Categorys = new CategoryRepository(_context);
        Invoices = new InvoiceRepository(_context);
        Products = new ProductRepository(_context);
        Sales = new SaleRepository(_context);
        Units = new UnitRepository(_context);
    }
    
    public async Task CompleteAsync()
    {
        await _context.SaveChangesAsync();
    }
}