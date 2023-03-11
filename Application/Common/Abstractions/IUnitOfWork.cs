namespace Application.Common.Abstractions;

public interface IUnitOfWork
{
    public ICategoryRepository Categorys { get;}
    public IInvoiceRepository Invoices { get;  }
    public IProductRepository Products { get; }
    public ISaleRepository Sales{ get;}
    public IUnitRepository Units { get; }
    Task CompleteAsync();
}